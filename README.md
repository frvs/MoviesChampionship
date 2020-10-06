# MoviesChampionship

Aplicação que, dado oito filmes pré-selecionados, gera um torneio entre eles e retorna os dois primeiros colocados.

## Requisitos
- `dotnet core 3.1`
- `git`

## Para rodar:
```
git clone https://github.com/frvs/MoviesChampionship.git
cd MoviesChampionship/Api
dotnet restore
dotnet run
```

## Decisões técnicas

A aplicação foi estruturada em três camadas: `Api`, `Application` e `Domain`.  
Em `Domain` são definidas as entidades do sistema e suas interfaces (de serviço, repositório etc).  
Em `Api` são tratadas as requisições HTTP seguindo a definição REST.  
Em `Application` ficam os serviços que fazem todo o processamento de dados.    

Uma decisão técnica que eu acho muito importante em processos seletivos é não cometer *overengineering*.  
Poderia ter feito uma solução mais complexa, desacoplando ainda mais os componentes, criando vários projetos e tal: mas o simples resolveu o problema proposto e ficou legível.   
Acho isso relevante :)  
