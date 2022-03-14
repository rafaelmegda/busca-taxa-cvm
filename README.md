# Importador Taxa CVM

Este sistema foi desenvolvido para realizar a importação da taxa CVM do endereço http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/. O Processo consiste em ler o arquivo .csv, salvar na base de dados, e disponibilizar através de API.


## O Sistema

### Versão Web do Importador

Este módulo é responsável por importar os arquivos da CVM, e permite ao usuário acompanhar o status atual da importação. Dessa forma é possível verificar se o arquivo para o determinado dia foi importado ou não.


#### Tela Inicial com os status de importação e botão para acessar o importador
![alt text](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/imgReadme/home.PNG)



#### Tela do importador de Taxas
![alt text](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/imgReadme/Importador.PNG)



### API Consulta Taxas CVM

Dentro da API é possível realizar a consulta das taxas CVM de três formas:


#### Retornar todas as taxas importadas (Sem filtro)
![alt text](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/imgReadme/ApiTodasTaxas.PNG)


#### Retornar todas as taxas importadas filtradas por CNPJ
![alt text](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/imgReadme/ApiSomenteCNPJ.PNG)


#### Retornar todas as taxas importadas filtradas por CNPJ e data inicial e data final
![alt text](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/imgReadme/ApiCNPJComDataInicialEDataFinal.PNG)



## Tecnologias Utilizadas
* .Net 2.1
* Entity Framework 2.1.1
* Pomelo.EntityFrameworkCore.MySql -Version 2.1.1
* Razor
* MySQL



## Como Rodar o Sistema

* Clonar este repositório para sua máquina
* Ter o [MySQL 8](https://dev.mysql.com/downloads/mysql/)  Instalado e em Execução na sua máquina 
* Instalar o [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) para consultar a base de dados
* Configurar a [String de conexão](https://github.com/rafaelmegda/busca-taxa-cvm/blob/master/BuscaDadosCVM/appsettings.json)
* Ter o [Visual Studio 2019 Community](https://visualstudio.microsoft.com/pt-br/vs/older-downloads/)
* No Visual Studio, Build o projeto e Rode o Projeto

### Para criar as tabelas no MySQL basta rodar os comandos abaixo dentro do Console de Gerenciador de Pacotes do Visual Studio. Esses comandos irão criar as migrations com base na classe de Models e ContextDataBase
* Add-Migration Initial
* Update-database


## Como Rodar a API

* Com o projeto Rodando você pode realizar a consulta usando o Postman ou inserindo diretamente no seu navegador do Chrome

### Endpoints:
* https://localhost:44380/api/Taxasimportadas/00017024000153/2020-01-10/2020-10-08
* https://localhost:44380/api/Taxasimportadas/00017024000153
* https://localhost:44380/api/Taxasimportadas

