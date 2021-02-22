class Rectangle {
   
   // Setup
   constructor (_width, _height, _color) {
      console.log('The Rectangle is being created !');
      this.width = _width;
      this.height = _height;
      this.color = _color;
   }

   getArea() {
      return this.width * this.height;
   }

   printDescription() {
      console.log(`I am a Rectangle of ${this.width} x ${this.height} and I am ${this.color}`);
   }

}

let myRectangle1 = new Rectangle(5, 3, 'blue');
let myRectangle2 = new Rectangle(51, 3, 'red');