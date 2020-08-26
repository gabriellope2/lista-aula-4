using System;

/*
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.*/

class MainClass {
  public static float Sinal(float n1, float n2,char operador){
  switch (operador){
    case '+':
      return n1 + n2;
    case '-':
      return n1 - n2;
    case '*':
      return n1 * n2;
    case '/':
      return n1 / n2;
    
    default:
      return 0;
  }
}

/*
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final*/
public static double ValorFinal(int codigo, int quantidade){
  double valor = 0; 
  if (codigo == 100){
    valor = 1.70;
    return valor * quantidade;
    }else if (codigo == 101){
      valor = 2.30;
      return valor * quantidade;
    }else if (codigo == 102){
      valor = 2.60;
      return valor * quantidade;
    }else if (codigo == 103){
      valor = 2.40;
      return valor * quantidade;
    }else if (codigo == 104){
      valor = 2.50;
      return valor * quantidade;
    }else if (codigo == 105){
      valor = 1;
      return valor * quantidade;
    }else{
      return 0;
    }
  }

/*
3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo
Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/

  public static void Exercicio3(){
    //3

    bool condiLoop = false;

    Console.Write("Candidatos:\n33 - José Couve\n25 - Joana Bravo\n10 - Roberto Nove\n0 - Voto branco\n4 - Voto nulo.\n");

    int escolha = 0; 
    int can1 = 0;
    int can2 = 0;
    int can3 = 0;
    int branco = 0;
    int nulo = 0;

    while (!condiLoop){
      Console.Write("Insira seu voto ou escolha 1 para sair >> ");
      escolha = int.Parse(Console.ReadLine()); 
      
       if (escolha == 33){
      can1 = can1 + 1;
      Console.Write("Voto concluido!\n\n");
    }else if (escolha == 25){
      can2 = can2 + 1;
      Console.Write("Voto concluido!\n\n");
    }else if (escolha == 10){
      can3 = can3 + 1;
      Console.Write("Voto concluido!\n\n");
    }else if (escolha == 0){
      branco = branco + 1;
      Console.Write("Voto concluido!\n\n");
      }
      else if (escolha == 4){
      nulo = nulo + 1;
      Console.Write("Voto concluido!\n\n");
      }
      else{
      Console.Write("Comando Inválido.");}



      if (escolha == 1){
        condiLoop = true;
        Console.WriteLine("Votos encerrados!\nJosé Couve >> {0} votos.\nJoana Bravo >> {1} votos.\nRoberto Nove >> {2} votos.\nVotos Brancos >> {3} votos.\nVotos Nulos >> {4} votos.\n",can1,can2,can3,branco,nulo);

    if( (can1 > can2) && ( can1 > can3 ) ){
      Console.WriteLine("Jose Couve foi o Vencedor!");
    }else if( can2 > can3 ){
      Console.WriteLine("Joana Bravo foi o Vencedor!");
    }else if((can1 == can2) && (can2 == can3)) {
       Console.WriteLine("Empate. Não Houve Vencedor!");
    }else{
      Console.WriteLine("Roberto Nove foi o Vencedor!");
    }}}


}

  public static void Main (string[] args) {
   // 1

    

    float n1;
    float n2;
    char operador;
    Console.Write("primeiro valor >> ");
    n1 = float.Parse(Console.ReadLine());
    Console.Write("segundo valor >> ");
    n2 = float.Parse(Console.ReadLine());
    Console.Write("operador \n+ soma\n-  subtração\n*  multiplicação\n/  divisão >> ");
    operador = char.Parse(Console.ReadLine());

    Console.WriteLine("Operação >> {0} {1} {2} = {3}",n1, operador,n2,Sinal(n1,n2,operador));
  
    Console.WriteLine("*************\n");

    //2

    

    int codigo;
    int quantidade;

    Console.WriteLine ("Código Produto Preço Unitário (R$)\n*************************\n100   Cachorro quente  R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n*************************");
    Console.Write("Código do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write(" quantidade >> ");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine("O valor total{0} R$.",ValorFinal(codigo, quantidade));
      

    
    
    Console.WriteLine("O valor total {0} R$.\n",ValorFinal(codigo, quantidade));

    Console.WriteLine("*************************");

    Exercicio3();

  }
}