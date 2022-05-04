/*/
function filtraPares(arr){
    return arr.filter((item){
        return item % 2 == 0;
    });
}
/*/

function filtraPares(arr){
    return arr.filter(callback);
}

function callback(item){
    return item % 2 == 0;
}

const meuArray = [1,2,5,6,3,9,7,75,1,14,15,16];

console.log(filtraPares(meuArray));