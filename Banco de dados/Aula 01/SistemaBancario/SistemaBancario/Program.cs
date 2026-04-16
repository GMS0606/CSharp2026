using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;
using static System.Console;

using var context = new BancoContext();

//Verifica se o db existe e cria se necessário 
//Cria as tabelas baseadas na entidades configuradas

try
{
    context.Database.EnsureCreated();
}
catch (Exception ex)
{
    WriteLine("Erro ao acessar ou criar o banco de dados:");
    WriteLine(ex.Message);
    return;
}

//Menu do programa 

WriteLine("===Sistema Bancário ===");
WriteLine("\n ---MENU PRINCIPAL---");
WriteLine("1- Cadastre nova conta");
WriteLine("2- Consultar conta existente");
WriteLine("3- Sair\n");
Write("Escolha uma opção: ");







