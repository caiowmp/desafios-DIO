
const meuArray = [30,30,40,5,223,2049,3034,5]

function valoresUnicos(arr)
{
    const mySet = new Set(arr);

    //Cria um novo array e copia cada valor do Set nesse array vazio (argumento hash)
    return [...mySet];
}

console.log(valoresUnicos(meuArray));