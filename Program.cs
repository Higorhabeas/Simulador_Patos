// See https://aka.ms/new-console-template for more information
//Alunos: Felipe Fernandes de Bellis Ruas
//        Higor Antônio da Silva

        ReadHeadDuck readHeadDuck = new ReadHeadDuck();
        readHeadDuck.Fly(); // Chamando o método Fly()
        readHeadDuck.Quack(); // Chamando o método Quack()
        readHeadDuck.Swim();

        // Criando uma instância de MallardDuck
        MallardDuck mallardDuck = new MallardDuck();
        mallardDuck.Fly(); // Chamando o método Fly()
        mallardDuck.Quack(); // Chamando o método Quack()
        mallardDuck.Swim();

        WoodenDuck woodenDuck = new WoodenDuck();
        woodenDuck.Swim();

        IronDuck ironDuck= new IronDuck();
       
/*Os principais ganhos dessa estratégia são a flexibilidade e a reutilização 
de código. Ao separar os comportamentos em interfaces, podemos criar diferentes 
combinações de comportamentos para os patos, sem precisar modificar a classe 
base ou criar subclasses separadas para cada combinação.
A estratégia de utilizar interfaces permite criar um sistema mais flexível, 
onde é fácil adicionar novos comportamentos aos patos sem afetar o código 
existente. Além disso, facilita a segregação de responsabilidades entre os 
desenvolvedores, pois cada interface define um papel específico que uma classe 
pode desempenhar.
Uma possível desvantagem dessa estratégia é a necessidade de implementar 
todos os métodos das interfaces em cada classe. Isso pode resultar em 
código duplicado se vários patos tiverem os mesmos comportamentos. 
Nesse caso, uma solução seria utilizar classes abstratas que implementam as 
interfaces e serem herdadas pelos patos.*/
