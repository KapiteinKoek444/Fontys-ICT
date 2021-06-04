let factor = 0;
let r;

function setup() {
    createCanvas(640, 640)
    r = width / 2 - 16;
}

function getVector(index, total) {
    let angle = map(index % total, 0, total, 0, TWO_PI);
    let v = p5.Vector.fromAngle(angle + PI);
    v.mult(r);
    return v;
}

function draw() {

    background(0)

    var total = 200;
    factor += 0.01;

    translate(width / 2, height / 2);
    stroke(220);
    noFill();
    circle(0, 0, r * 2);


    for (let i = 0; i < total; i++) {
        var v = getVector(i, total);

        fill(255);
        circle(v.x, v.y, 8);
    }

    for (let i = 0; i < total; i++) {
        let a = getVector(i, total);
        let b = getVector(i * factor, total);
        line(a.x, a.y, b.x, b.y);
    }
}