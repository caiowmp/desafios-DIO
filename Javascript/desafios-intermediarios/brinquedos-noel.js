var participantes = gets();
var criancas;
var array = [];
for(var i = 0; i<participantes; i++){
  criancas = gets().split(' ');
  array.push(criancas[1]);
}

const meninos = array.filter((item){ return item == 'M';}).length;
const meninas = array.filter((item){ return item == 'F';}).length;
print(`${meninos} carrinhos\n${meninas} bonecas`);