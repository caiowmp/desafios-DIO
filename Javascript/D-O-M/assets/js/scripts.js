function mudaModo(){
    mudaClasses();
    mudaTextos();
}

function mudaClasses(){
    botao.classList.toggle('dark-mode');
    h1.classList.toggle('dark-mode');
    body.classList.toggle('dark-mode');
    footer.classList.toggle('dark-mode');
}

function mudaTextos(){
    if(body.classList.contains('dark-mode')){
        botao.innerHTML = "Light mode";
        h1.innerHTML = "Dark mode ON";
        return;
    } 

    botao.innerHTML = "Dark mode";
    h1.innerHTML = "Light mode ON";
}

const botao = document.getElementById('mode-selector');
const h1 = document.getElementById('page-title');
//retorna uma lista, mas como só existe um body, podemos nos referenciar a ele com o índece[0]
const body = document.getElementsByTagName('body')[0];
const footer = document.getElementsByTagName('footer')[0];


botao.addEventListener('click', mudaModo);