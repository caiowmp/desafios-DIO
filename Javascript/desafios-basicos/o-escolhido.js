let alunos = gets();
let matricula = 0;

for(var i =0;i<alunos;i++){
    entrada = gets().split(" ");
    if(parseFloat(entrada[1])>= 8){
        matricula = parseInt(entrada[0]);
    }
}

if(matricula != 0)
    print(matricula);
else
    print("Minimum note not reached")