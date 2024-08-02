# Day-6
Entendendo sobre Herença

[Day 6]

Olá pessoal, como vocês estão? 😊

Hoje partiremos para o que, para muitos, é o segundo pilar da Orientação a Objetos (POO): a Herança.

Mas afinal, o que é a herança na Programação Orientada a Objetos? A Programação Orientada a Objetos faz um paralelo ao mundo real. O encapsulamento, assim como uma cápsula, protege o que está dentro dessa cápsula do mundo exterior, evitando que se estrague ou perca o seu efeito 💊. A herança segue o mesmo raciocínio: da mesma forma que um filho(a) herda as características do pai ou da mãe, uma classe também pode herdar características de outra classe 👨‍👩‍👧.

Vamos a um exemplo rápido e básico: temos uma classe A (Classe pai) e uma classe B (Classe filho). Quando a classe B herda a classe A, a classe B terá todas as características de A. Trazendo para a programação, se a Classe A tem atributos e métodos, a classe B também vai herdar esses atributos e métodos 📋.

Em C#, representamos a herança com ":" e, nesse exemplo que coloquei abaixo, aparecem esses dois pontos ali do lado do nome da classe Gerente: (herda de) Funcionario, e abaixo está toda a regra de negócio da Classe, tanto dos atributos quanto dos métodos. Outro ponto a se observar é quando a classe pai tem um construtor e esse construtor tem seus argumentos (ou parâmetros). A classe filha, que no caso é Gerente, tem que mandar os argumentos para o construtor da classe pai. Pode parecer confuso, mas percebe-se que ao lado do construtor Gerente tem um ": base (nome, salario)". Isso acontece porque, quando a classe pai tem um construtor com argumentos, o filho tem que passar os argumentos para o construtor do pai 🏗️. Assim como no método ExibirDetalhes, onde há um ".base" na classe Gerente, isso quer dizer que ele vai pegar as informações do método ExibirDetalhes da Funcionario, mais o que tem que exibir na tela da classe Gerente.
