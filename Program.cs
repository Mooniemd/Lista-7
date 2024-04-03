/*
QUEST 1 - Contagem regressiva 10 ao 1.
int i = 1;
Console.WriteLine("Você deseja explodir a bomba? (sim ou nao)");
string? escolha = Console.ReadLine()!.ToLower();

while(i <= 10){
  if(escolha == "sim"){
    Console.WriteLine($"{i}..");
      i++;
  } if( i > 10){
    Console.WriteLine("Kabummmm!!! Sua bomba explodiu!");
  } else if (escolha == "nao"){
    Console.WriteLine("Que chato..");
    break;
  }
}*/


/*
QUEST 2 (Versão moonie) - Calcule e imprima os números até um número negativo for inserido.
bool valor = true;
int soma = 0;

while(valor){
  Console.WriteLine("Digite números pra eu somar!");
  int num = int.Parse(Console.ReadLine()!);
  if( num >= 0){
    soma += num;
  } else if (num <= 1){
    valor = false;
    Console.WriteLine($"Não faço soma com números negativos! mas sua soma total foi {soma}");
  }
}*/

/*
QUEST 2 (Versão exemplo pro José e Vito)
int num = 1;
int soma = 0;

while(num >= 0){
  Console.WriteLine("Digite números!");
  num = int.Parse(Console.ReadLine()!);

  if ( num <= -1){
    Console.WriteLine($"Não somo negativos! Seu total foi {soma}");
  } else{
    soma += num;
  }
}*/


/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */