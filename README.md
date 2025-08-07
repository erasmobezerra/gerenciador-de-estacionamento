# 🚗 Sistema de Gerenciamento de Estacionamento

## 📖 Sobre o Projeto

Este projeto foi desenvolvido como parte do desafio da **Trilha .NET - Fundamentos**. Trata-se de um sistema de gestão de estacionamento que permite gerenciar os veículos estacionados e realizar operações essenciais como:

- ➕ Adicionar veículos
- ➖ Remover veículos (com cálculo automático do valor)
- 📋 Listar veículos estacionados

## 🎯 Visão Geral

O objetivo principal foi implementar três métodos fundamentais do sistema, aplicando boas práticas de programação e tratamento de erros para criar uma solução robusta e confiável.

## 💻 Estrutura do Projeto

```
DesafioFundamentos/
├── Models/
│   └── Estacionamento.cs
├── Program.cs
└── README.md
```
## Tecnologias Empregadas

  <img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" />
  <img alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /> 

## ⚙️ Funcionalidades Implementadas

### 🔧 Métodos Principais

| Método | Descrição |
|--------|-----------|
| **AdicionarVeiculo** | Recebe a placa digitada pelo usuário e armazena na lista de veículos |
| **RemoverVeiculo** | Verifica se o veículo está estacionado, calcula o valor baseado no tempo de permanência usando a fórmula: `precoInicial + (horas × precoPorHora)` |
| **ListarVeiculos** | Exibe todos os veículos atualmente estacionados ou mensagem informativa caso não haja nenhum |

### 🛡️ Melhorias de Qualidade

- **Tratamento de Erros**: Validação para entradas inválidas (placas vazias, horas negativas)
- **Imutabilidade**: Atributos da classe declarados como `readonly`
- **Boas Práticas**: Nomenclatura padronizada com prefixo "_" para atributos privados
- **Código Limpo**: Nomes de variáveis mais descritivos e organização estrutural

## 📋 Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas:

- 🔹 **.NET 8.0** ou superior
- 🔹 **IDE**: Visual Studio 2022, VS Code ou similar

## 🚀 Como Executar

```bash
# 1. Clone o repositório
git clone https://github.com/erasmobezerra/trilha-net-fundamentos-desafio

# 2. Navegue até a pasta do projeto
cd trilha-net-fundamentos-desafio/trilha-net-fundamentos-desafio/DesafioFundamentos

# 3. Execute o projeto
dotnet run
```



## 🧪 Exemplo de Uso

```csharp
// Criando uma instância do estacionamento
var estacionamento = new Estacionamento(precoInicial: 5.00m, precoPorHora: 2.00m);

// Adicionando veículos
estacionamento.AdicionarVeiculo("ABC-1234");

// Listando veículos
estacionamento.ListarVeiculos();

// Removendo veículo (será solicitado o tempo de permanência)
estacionamento.RemoverVeiculo("ABC-1234");
```

## 📬 Contato

<div align="left">

**Erasmo Bezerra**

[![Email](https://img.shields.io/badge/Email-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:erasmo.ads.tech@gmail.com)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/erasmobezerra/)

</div>

## 🙏 Agradecimentos

Agradeço profundamente à **Digital Innovation One** por proporcionar este aprendizado gratuito e de qualidade. Um reconhecimento especial ao professor **[Leonardo Buta](https://www.linkedin.com/in/leonardo-buta/)** pela excelente didática e orientação durante todo o processo.

---

<div align="center">
  <p>⭐ Se este projeto foi útil para você, considere dar uma estrela!</p>
</div>