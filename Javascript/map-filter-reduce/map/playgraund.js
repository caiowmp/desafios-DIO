const maca = {
    value: 2,
};

const laranja = {
    value: 3,
};

function mapComThis(arr, thisArg){
    return arr.map(function(item){
        return item * this.value;
    }, thisArg);
}

const num = [1,5]

console.log('this -> maçã',mapComThis(num,maca));

console.log('this -> laranja',mapComThis(num,laranja));