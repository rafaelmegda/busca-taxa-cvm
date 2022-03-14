# Importador Taxa CVM

Este sistema foi desenvolvido para realizar a importação da taxa CVM do endereço http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/. O Processo consiste em ler o arquivo .csv, salvar na base de dados, e disponibilizar através de API.


## O Sistema


## Tecnologias Utilizadas
* .Net 2.1
* Entity Framework 2.1.1
* Razor
* MySQL

## Como Rodar o Sistema


## Como Rodar a API

Install-Package
Pomelo.EntityFrameworkCore.MySql -Version 2.1.1

MySQL
Atualizar a String de Conexão com o Banco Local informando o usuário e senha

Migrations
Add-Migration Initial
Update-database
