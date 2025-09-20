# TrabalhoPOO
# 🏷️ Sistema de Estoque – Windows Forms + PostgreSQL

Um sistema simples de **controle de estoque** feito em **C# com Windows Forms**, permitindo **cadastrar produtos**, **incrementar** e **decrementar** quantidades em um banco de dados **PostgreSQL**, 
exibindo as informações em tempo real em um **DataGridView**.

---

## 🚀 Começando

Essas instruções permitirão que você obtenha uma cópia do projeto em funcionamento na sua máquina local para fins de desenvolvimento e teste.

Consulte **Implantação** para saber como colocar o projeto em um ambiente de produção.

### 📋 Pré-requisitos

Antes de começar, você precisa ter:

* [Visual Studio](https://visualstudio.microsoft.com/) (ou Rider, VS Code com extensão C#)  
* [.NET 6 ou superior](https://dotnet.microsoft.com/en-us/download)  
* [PostgreSQL](https://www.postgresql.org/download/) instalado e rodando  
* **Pacote NuGet:** [Npgsql 9.0.3](https://www.nuget.org/packages/Npgsql/) – usado para conectar ao PostgreSQL  

Opcional (mas recomendado):

* [pgAdmin](https://www.pgadmin.org/) para gerenciar o banco de dados

### 🔧 Instalação

1. **Clone este repositório:**

```bash
git clone https://github.com/seu-usuario/sistema-estoque.git
```

2. **Configure o banco de dados no PostgreSQL:**

```sql
CREATE DATABASE estoque;
\c estoque
CREATE TABLE produto (
    id_produto SERIAL PRIMARY KEY,
    nome VARCHAR(100) UNIQUE NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    quantidade INT NOT NULL
);
```

3. **Ajuste a string de conexão:**

Abra o arquivo `Banco/Configuracao_DB.cs` e edite a `ConnectionString` com suas credenciais:

```csharp
private static string connectionString =
    "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=estoque";
```

4. **Compile e execute:**

No Visual Studio, selecione **Executar (F5)** para iniciar o sistema.

---

## 📂 Estrutura do Projeto

A solução está organizada da seguinte forma:

```
TrabalhoPOO
│
├─ Dependencies
│  ├─ Frameworks
│  │  ├─ Microsoft.NETCore.App
│  │  └─ Microsoft.WindowsDesktop.App.WindowsForms
│  └─ Packages
│     ├─ Npgsql (9.0.3)
│     └─ System.Configuration.ConfigurationManager (8.0.0)
│
├─ Banco
│  └─ Configuracao_DB.cs         # Configuração da conexão com o PostgreSQL
│
├─ Form1
│  ├─ Form1.cs                   # Lógica principal da aplicação
│  ├─ Form1.Designer.cs          # Código gerado pelo Windows Forms Designer
│  └─ Form1.resx                 # Recursos da interface (ex.: textos, layout)
│
└─ Program.cs
```
 
