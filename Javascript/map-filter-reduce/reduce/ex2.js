const lista = [{
    name: 'sabão em pó',
    preco: 30
},
{
    name: 'cereal',
    preco: 12
},
{
    name: 'toalha',
    preco: 30
},
];

saldoDisponivel = 100;

function calculaSaldo(saldoDisponivel,lista){
    return lista.reduce( function(prev,current){
        return prev - current.preco;
    }, saldoDisponivel);
}

console.log(calculaSaldo(saldoDisponivel,lista));