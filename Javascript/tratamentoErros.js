
function validaArray(arr,num)
{
    try
    {
        //verifica se os valores foram passados
        if(!arr && !num) throw new ReferenceError("Envie os parâmentros");

        //verifica se o arr é do tipo object
        if(typeof arr !== 'object') throw new TypeError("O array precisa ser do tipo object");

        //verifica se o arr é do tipo number
        if(typeof num !== 'number') throw new TypeError("Num precisa ser do tipo number");

        if(arr.length !== num) throw new RangeError("Tamanho invalido!");

        return arr;
    }
    catch(e)
    {
        if(e instanceof ReferenceError)
        {
            console.log("Este erro é um ReferenceError!");
            console.log(e.message);
        } 
        else if(e instanceof TypeError)
        {
            console.log("Este erro é um TypeError!");
            console.log(e.message);
        } 
        else if(e instanceof RangeError)
        {
            console.log("Este erro é um RangeError!");
            console.log(e.message);
        } 
        else
        {
            console.log("Tipo de erro não esperado: " + e);
        }
    }
}

//caso 1:
//console.log(validaArray());
//caso 2:
//console.log(validaArray(5,5));
//caso 3:
//console.log(validaArray([],'a'));
//caso 4:
//console.log(validaArray([1,2,3],2));
//caso 5: (Tudo certo)
console.log(validaArray([1,2],2))