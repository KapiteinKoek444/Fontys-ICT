var symbolSize = 20;
var streams = [];

function setup() {
    createCanvas(window.innerWidth, window.innerHeight);
    background(0);
    var x = 0;
    for (var i = 0; i <= width / symbolSize; i++) {
        var stream = new Stream();
        stream.generateSymbols(x, random(-1000, 0));
        streams.push(stream);
        x += symbolSize;
    }
    textSize(symbolSize)
}

function draw() {
    background(0, 200);
    streams.forEach(function (stream) {
        stream.render();
    });
}

function symbol(x, y, speed, first) {
    this.x = x;
    this.y = y;
    this.speed = speed;
    this.first = first;
    this.switchInterval = round(random(2, 20));
    this.value;

    this.setToRandomSymbol = function () {
        if (frameCount % this.switchInterval == 0) {
            this.value = String.fromCharCode(0x30A0 + round(random(0, 90)));
        }
    }

    this.rain = function () {
        this.y = (this.y >= height) ? 0 : this.y += this.speed;
    }
}

function Stream() {
    this.symbols = [];
    this.totalSymbols = round(random(4, 30));
    this.speed = random(3, 7);

    this.generateSymbols = function (x, y) {
        var first = round(random(0, 1)) == 1;
        for (var i = 0; i <= this.totalSymbols; i++) {
            sym = new symbol(x, y, this.speed, first);
            sym.setToRandomSymbol();
            this.symbols.push(sym);
            y -= symbolSize;
            first = false;
        }
    }

    this.render = function () {
        this.symbols.forEach(function (sym) {
            if (sym.first) {
                fill(180, 255, 180)
            } else {
                fill(0, round(random(150, 255)), 70);
            }
            text(sym.value, sym.x, sym.y);
            sym.rain();
            sym.setToRandomSymbol();
        });
    }
}