class Square {
   constructor (_width) {
      this.width = _width;
      this.height = _width;
      this.numOfRequestForArea = 0;
   }

   get area () {
      this.numOfRequestForArea++;
      return this.width * this.height;
   }

   set area (area) {
      this.width = Math.sqrt(area);
      this.height = this.width;
   }

}

let square = new Square(4);
square.area = 25;
console.log(square.numOfRequestForArea);