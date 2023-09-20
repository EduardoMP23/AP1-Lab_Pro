//Declarando váriaveis
string resp="verdade";
string faixa="";
double imc=0;
string imcc="";

//Iniciando o loop
do
{

//Coletando os dados iniciais
Console.WriteLine("Digite seu nome:");
string? nome=Console.ReadLine();
Console.WriteLine("Seu peso:");
double peso=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Sua altura:");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("E por ultimo sua idade");
int idade=Convert.ToInt32(Console.ReadLine());

//Calculo do imc
imc = peso/(altura*altura);

//Definindo a classificação do imc
if (imc <18.5)
{
imcc="Abaixo do normal";
}
else if(imc >= 18.5 & imc <= 24.9 )
{
imcc="Peso normal";    
}
else if(imc >= 25 & imc <= 29.9)
{
imcc="Execesso de peso"; 
}
else
{
imcc="Obesidade";
}

//Definindo a faixa etária
if(idade<=12)
{
    faixa="Criança";
}
else if(idade>=13 & idade<=19)
{
    faixa="Jovem";
}
else if(idade>=20&idade<=59)
{
    faixa="Adulto";
}
else
{
    faixa="Idoso";
}

//Gerando o relatório
Console.WriteLine("-------Relatório-------");
Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nFaixa etária: "+faixa);
Console.WriteLine($"IMC: {imc} Classificação: "+imcc);

//Perguntando se finaliza o programa ou não
Console.WriteLine("Gostaria de gerar outro relatorio ? (s/n)");
resp=Console.ReadLine();
}

//Fim do loop
while(resp == "s");
{
Console.WriteLine("Até Breve");
}