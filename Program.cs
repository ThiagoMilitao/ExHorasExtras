double salarioHora, salario;
int horasTrabalhadas, horasExtras;

//solicitar entradas
Console.WriteLine("Digite o salário-hora base:");
salarioHora = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de horas trabalhadas:");
horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de horas extras:");
horasExtras = int.Parse(Console.ReadLine());

//calcular o salário

salario = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

Console.WriteLine($"O salário é: {salario:C2}");

double CalcularSalario(double salarioHora, int horasExtras, int horasTrabalhadas){
    return  (salarioHora * horasTrabalhadas + (horasExtras * 1.4 * salarioHora));
}