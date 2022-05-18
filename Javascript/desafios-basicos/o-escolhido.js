let alunos = gets();
let maior_matricula = "Minimum note not reached";
let maior_nota = 0;

for(var i =0;i<alunos;i++){
    entrada = gets().split(" ");
    let matricula = parseInt(entrada[0]);
    let nota = parseFloat(entrada[1]);
    if(nota >= 8 && nota > maior_nota){
        matricula_maior = matricula;
        maior_nota = nota;
    }
}

print(matricula);