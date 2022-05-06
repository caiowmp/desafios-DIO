let alunos = gets();
let matricula = 0;
let notas = 0;

for(var i =0;i<alunos;i++){
    entrada = gets().split(" ");
    if(parseFloat(entrada[1])>= 8 && entrada[1] > notas){
        matricula = parseInt(entrada[0]);
        notas = parseInt(entrada[1]);
    }
}

if(matricula != 0)
    print(matricula);
else
    print("Minimum note not reached");