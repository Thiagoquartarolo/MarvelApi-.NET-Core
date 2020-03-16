# MarvelApi-.NET-Core
.NET Core 3.1 + EF In-Memory + Swagger

** Ferramentas Necessárias **
- Visual Studio Code
- Postman


* Certificar-se que a versão do .NET Core seja 3.0 ou superior *
* Atualizar a versão do SDK .NET Core para a versão mais recente(3.1.2 atualmente) - https://dotnet.microsoft.com/download


** Baixar **
- Clonar o projeto MarvelApi-.NET-Core para o desktop. Clique no botão "Clone or download"
- Utilizar as opções "Clone with SSH"
- Abrir Git Bash, direcionar para a pasta onde deseja realizar o clone da aplicação e digitar no console: 
	$ git clone git@github.com:Thiagoquartarolo/MarvelApi-.NET-Core.git


** Compilar **
*Visual Studio Code
- Abrir o terminal e executar o comando: dotnet restore 


** Executar **
*Visual Studio Code
- Apertar a tecla F5. A aplicação será automaticamente executada.


** Documentação **
- https://localhost:44309/swagger


** Testar **
* Postman

*Caso o Postman esteja configurado para validar HTTPS, desmarcar a opção de validar SSL*
- File > Settings > SSL certificate verification > off

GET - https://localhost:44309

/v1/public/characters
/v1/public/characters/{characterId}
/v1/public/characters/{characterId}/comics
/v1/public/characters/{characterId}/events
/v1/public/characters/{characterId}/series
/v1/public/characters/{characterId}/stories
