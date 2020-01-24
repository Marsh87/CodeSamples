class Employee {
    constructor(id,name) {
        this.id = id;
        this.name = name;
    }

    detail() {
        return this.id + "" + this.name;
    }
}