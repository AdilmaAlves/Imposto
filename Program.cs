double salario,valorImposto = 0;
double dFaixa0 = 0;
double dFaixa1 = 5;
double dFaixa2 = 10;
double dFaixa3 = 20;


Console.WriteLine("Digite o valor do salário bruto: ");
salario = double.Parse(Console.ReadLine());

if(salario <= 900.00){   
    valorImposto = (dFaixa0*(salario/100));
}
else if(salario > 900.00 && salario <= 1500.00){
    valorImposto = ((salario/100)*dFaixa1);
}
else if(salario < 1500.00 && salario <= 2500.00){
    Console.WriteLine("Faixa 3");
   valorImposto = ((salario/100)*dFaixa2); 
}
else if(salario > 2500.00){
   valorImposto = ((salario/100)*dFaixa3);
}

Console.WriteLine($"Valor que será cobrado de imposto: {valorImposto}");