Projeto criado em um teste de entrevista para seguir as demandas abaixo:

1. Faça a aplicação na linguagem que você optou e queremos uma tela que permite a digitação de números aleatórios e nos mostre (esses números) na tela mas de forma ordenada.
2. Em seguida, grave esses números digitados em um arquivo txt sendo obrigatório 1 número por linha, se você por exemplo digitou 5 números, serão 5 linhas no arquivo e importante salva-lo com o nome: numeros_ordenar.txt numa pasta nova que depois será submetida para nós.
3. Em seguida, crie uma lista contendo 100 itens de uma classe de nome clsTeste com as propriedades codigo como número e descricao como texto, os objetos deverão ser criados com a propriedade codigo com números sequenciais (ex: 1,2,3,4,5) e a descricao como a data e hora atual (ex: 2022/10/13 08:50:22.123).
4. Grave essa lista (item 3) em um arquivo com o nome data.json na mesma pasta recém criada.
5. Crie um Grid na sua aplicação, depois leia o arquivo data.json que você gravou e mostre os dados na tela dentro do Grid criado.
6. Agora vamos aumentar o nível, precisamos que você Consuma o webservice dos correios passando um CEP qualquer (exemplo: 04144020) e mostre na tela o endereço que o mesmo retornar.
Endereço: https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl Método: consultaCEP
7. Consuma a API para buscar a lista de bancos brasileiros
Documentação: https://brasilapi.com.br/docs#tag/BANKS/paths/~1banks~1v1/get
URL: https://brasilapi.com.br/api/banks/v1
Mostre os dados de retorno da API em um Grid.

Para rodar o projeto utilize um servidor SQL Server, faça o apontamento para o seu servidor no arquivo Program.cs e execute o comando update-database no console do NuGet
