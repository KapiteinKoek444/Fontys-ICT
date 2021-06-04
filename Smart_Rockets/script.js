var popul;
var lifespan = 300;
var lifeP;
var count = 0;
var target;
var maxForce = 0.2;
var gencount = 1;

var rX = 100;
var rY = 150;
var rW = 200;
var rH = 10;

function setup() {
    createCanvas(400, 400);
    popul = new Population();
    lifeP = createP();
    target = createVector(width / 2, 20);
}

function draw() {
    background(0);
    popul.run();
    lifeP.html("Gen:" + gencount);
    count++;

    if (count == lifespan) {
        popul.evaluate();
        popul.selection();
        count = 0;
        gencount++;
    }

    fill(255);
    rect(width / 2 - rW / 2, rY, rW, rH);

    fill(255, 0, 0)
    ellipse(target.x, target.y, 16, 16);
}

function Population() {
    this.rockets = [];
    this.matingpool = [];
    this.popSize = 25;

    for (var i = 0; i < this.popSize; i++) {
        this.rockets[i] = new Rocket();
    }

    this.evaluate = function () {
        var maxfit = 0;

        for (var i = 0; i < this.popSize; i++) {
            this.rockets[i].calcFitness();
            if (this.rockets[i].fitness > maxfit) {
                maxfit = this.rockets[i].fitness;
            }
        }
        console.log(this.rockets);

        for (var i = 0; i < this.popSize; i++) {
            this.rockets[i].fitness / maxfit;
        }

        this.matingpool = [];
        for (var i = 0; i < this.popSize; i++) {
            var n = this.rockets[i].fitness * 100;
            for (var j = 0; j < n; j++) {
                this.matingpool.push(this.rockets[i])
            }
        }
    }

    this.selection = function () {
        var newRockets = [];
        for (var i = 0; i < this.rockets.length; i++) {
            var parentA = random(this.matingpool).dna;
            var parentB = random(this.matingpool).dna;
            var child = parentA.crossover(parentB);
            child.mutation();
            newRockets[i] = new Rocket(child);
        }
        this.rockets = newRockets;
    }

    this.run = function () {
        for (var i = 0; i < this.popSize; i++) {
            this.rockets[i].update();
            this.rockets[i].show();
        }
    }
}

function DNA(genes) {

    if (genes) {
        this.genes = genes;
    } else {
        this.genes = [];

        for (var i = 0; i < lifespan; i++) {
            this.genes[i] = p5.Vector.random2D();
            this.genes[i].setMag(maxForce);
        }
    }

    this.crossover = function (partner) {
        var newgenes = [];
        var mid = floor(random(this.genes.length));
        for (var i = 0; i < this.genes.length; i++) {
            if (i > mid) {
                newgenes[i] = this.genes[i];
            } else {
                newgenes[i] = partner.genes[i];
            }
        }
        return new DNA(newgenes);
    }

    this.mutation = function () {
        for (var i = 0; i < this.genes.length; i++) {
            if (random(1) < 0.01) {
                this.genes[i] = p5.Vector.random2D();
                this.genes[i].setMag(maxForce);
            }
        }
    }
}

function Rocket(dna) {
    this.pos = createVector(width / 2, height - 10);
    this.vel = createVector();
    this.acc = createVector();
    this.completed = false;
    this.crashed = false;
    if (dna) {
        this.dna = dna;
    } else {
        this.dna = new DNA();
    }
    this.fitness = 0;

    this.applyForce = function (force) {
        this.acc.add(force);
    }

    this.calcFitness = function () {
        var d = dist(this.pos.x, this.pos.y, target.x, target.y)

        this.fitness = map(d, 0, width, width, 0);
        if (this.completed) {
            this.fitness *= 100;
        }

        if (this.crashed) {
            this.fitness /= 100;
        }
    }

    this.update = function () {
        var d = dist(this.pos.x, this.pos.y, target.x, target.y);
        if (d < 5) {
            this.completed = true;
            this.pos = target.copy();
        }

        if (this.pos.x > rX && this.pos.x < rX + rW && this.pos.y > rY && this.pos.y < rY + rH) {
            this.crashed = true;
        }

        if (this.pos.x > width || this.pos.x < 0 || this.pos.y > height || this.pos.y < 0) {
            this.crashed = true;
        }

        this.applyForce(this.dna.genes[count]);
        if (!this.completed && !this.crashed) {
            this.vel.add(this.acc);
            this.pos.add(this.vel);
            this.acc.mult(0);
            this.vel.limit(4);
        }
    }

    this.show = function () {
        push();
        noStroke();
        fill(255, 150);
        translate(this.pos.x, this.pos.y);
        rotate(this.vel.heading());
        rectMode(CENTER)
        rect(0, 0, 25, 5);
        pop();
    }
}