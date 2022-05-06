let alunos = gets();
let matricula = 0;

for(var i =0;i<alunos;i++){
  entrada = gets();
  alunos = entrada.split(" ");
  if(parseFloat(alunos[1])>= 8){
    matricula = alunos[0];
  }
}

if(matricula != 0)
 print(matricula);
else
  print("Minimum note not reached")