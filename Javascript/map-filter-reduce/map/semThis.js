function mapSemThis(arr){
    return arr.map(function(item){
        return item * 2;
    });
}

const num = [2,4,5,6]

console.log(mapSemThis(num));