
function getAdmins(map)
{
    //Inicializando um vetor
    let admins = []
    for([key,value] of map)
    {
        if(value == 'Admin')
        {
            //Adicionando valores no vetor
            admins.push(key);
        }
    }

    return admins;
}

//Inicializando o Map
const usuarios = new Map();

//Introduzindo elementos no Map
usuarios.set('Luiz','Admin');
usuarios.set('Stephanie','Admin');
usuarios.set('Jorge','User');
usuarios.set('Natalia','Admin');

//printa na tela
console.log(getAdmins(usuarios));

// node 'nome do arquivo' roda o programa