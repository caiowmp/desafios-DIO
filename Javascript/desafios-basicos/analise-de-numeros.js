let valoresPares = 0;
let valoresImpares = 0;
let valoresPositivos = 0;
let valoresNegativos = 0;

for (var i = 0; i < 5; i++) {
  const valorInformadoPeloUsuario = parseInt(gets());

  if (valorInformadoPeloUsuario % 2 == 0) {
    valoresPares++;
  } else {
    valoresImpares++;
  }

  if (valorInformadoPeloUsuario > 0) {
    valoresPositivos+=1;
  } else if (valorInformadoPeloUsuario < 0) {
    valoresNegativos+=1;
  }

}

console.log(`${valoresPares} par(es)`);
console.log(`${valoresImpares} impar(es)`);
console.log(`${valoresPositivos} positivo(s)`);
console.log(`${valoresNegativos} negativo(s)`);