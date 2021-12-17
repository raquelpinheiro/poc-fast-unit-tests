# poc-fast-unit-tests

Este projeto consiste de uma WebApi em ASP.NET Core, utilizando o framework XUnit para os testes unitários.

O objetivo desse projeto é mostrar as práticas ruins, que deixam a execução dos testes unitários e também as boas práticas que deixam a execução dos testes unitários rápida.

Boas práticas para testes rápidos:

1. Testes do tipo [FACT]: Instanciar uma única vez o objeto do cenário de teste

 Utilize os objetos em um contexto compartilhado, instanciando os objetos apenas uma vez.
 Faça isso criando classes que herdem de IClassFixture ou ICollectionFixture, implementando também IDisposable.
 
 [Shared Context - XUnit](https://xunit.net/docs/shared-context)
 [ClassFixture - XUnit](https://xunit.net/docs/shared-context#class-fixture)
 
 Coloque seus objetos em métodos apenas de leitura sendo instanciados no construtor. Classes "Fixtures" vão ser instanciadas 
 apenas uma vez (Singleton).
 
 Além de que todo o trabalho de coleta de lixo (Garbage Collector) será feito na ClassFixture, melhorando bastante a performance do teste.
  
 Uma boa observação: geralmente as pessoas preferem utilizar bibliotecas como o [AutoBogus](https://github.com/nickdodd79/AutoBogus) para instanciar objetos, e isso facilita bastante, por exemplo, para você não ter que atribuir todos os atributos de um objeto.
 Não me entenda mal, essas bibliotecas são ótimas, economizam nosso tempo, mas nós precisamos saber utiliza-lás.
 Se a biblioteca faz uso de Reflection (que é o caso da AutoBogus, é aí que vai ser bem necessário instanciar objetos apenas uma única vez!
 Em alguns poucos testes isso não vai fazer tanta diferença, mas pense em um projeto grande que tenha milhares de testes.

2. Testes do tipo [THEORY]: Instancie e passe objetos de métodos estáticos usando [MemberData]

 Não é à toa a obrigatoriedade de passar objetos estáticos do tipo Theory<T> como parâmetro nos em testes do tipo [THEORY].
 Sendo objetos estáticos, mais uma vez será otimizanda alocação em memória e a coleta de lixo.

 
- Testes precisam executar rápido, devem levar milesegundos para executar. E nós precisamos disso visto sempre que alteramos 
um método, nós precisamos executar todos os testes existentes para assegurar que os demais métodos continuam funcionando 
depois de nossas alterações.