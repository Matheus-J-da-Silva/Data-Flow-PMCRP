<h1 align="left"> Data-Flow PMCRP </h1>  


O **Data-Flow do PMCRP** É uma ferramenta que nasceu da necessidade de automatizar e gerenciar a **coleta**, o **tratamento** e a **carga** (ETL) de diversas fontes de dados públicos, como **ANP**, **TCEs**, **portais de transparência municipais**, entre outros, de forma **moderna**, **multiplataforma** e com uma **interface visual amigável e interativa**.

A proposta metodológica do projeto é baseada em uma arquitetura **MVVM modular** e**Arquitetura em Camadas** , inspirada em práticas de **Data Harvesting**, com forte foco em **experiência do usuário**, **escalabilidade** e **manutenibilidade**.

Utilizando **C#** e **.NET MAUI**, o sistema oferece uma aplicação gráfica **cross-platform** (Windows, Android, macOS e iOS) para gerenciamento do pipeline de dados, permitindo que o ETL seja **interativo**, **robusto**, **organizado por módulos** e **fácil de estender**.

> ⚠️ **Este não é um ETL convencional.**  
> Trata-se de uma solução pensada para evoluir junto com a complexidade dos dados e das demandas analíticas, com componentes **modulares**, **testáveis** e **reutilizáveis**, seguindo boas práticas de engenharia de software.

---


### 🧱 Estrutura do Projeto

```
Data-Flow/
├── Application/
│   ├── Interfaces/
│   │   ├── IDataFlowService.cs
│   │   ├── ISiteRepository.cs
│   ├── Services/
│   │   └── ColetaService.cs
│
├── Domain/
│   ├── Entities/
│   │   └── DataFlowEntity.cs
│
├── Infrastructure/
│   ├── Http/
│   │   └── HttpClientFactory.cs (opcional)
│   ├── Scraping/
│   │   └── HtmlAgilityScrapingService.cs
│   ├── Data/
│   │   ├── Db/
│   │   │   └── app.db
│   │   └── Repositories/
│   │       └── SiteRepository.cs
│
├── bin/                        # arquivos compilados pelo .NET
├── obj/                        # metadados e cache de build
├── Components/                 # Componentes reutilizaveis
├── Platforms/                  
│   ├── Android/
│   ├── Windows/
│   ├── MacCatalyst/
│   └── iOS/
├── Resources/                  # recursos do MAUI
│   ├── Images/                 # imagens da aplicação
│   ├── Fonts/                  # fontes customizadas
│   ├── Styles/                 # estilos globais (XAML)
│   └── Raw/                    # arquivos brutos, modelos e DTOs
├── App.xaml                    # configuração global da aplicação
├── App.xaml.cs
├── MauiProgram.cs              # bootstrap / DI / configuração do app
├── appsettings.json            # configurações da aplicação
├── DataFlow.csproj
├── .gitignore
└── README.md
```

---

### ⚙️ Tecnologias Utilizadas

* **C# 12**
* **.NET 8 / .NET 9 (preview ou superior)**
* **.NET MAUI**  
* **Blazor** 
* **HTML**
* **CSS**
* **Bootstrap 5**   


  Framework multiplataforma para construção da interface gráfica.
* **MVVM (Model-View-ViewModel)**
* **Dependency Injection (DI) nativo do .NET**
* **HttpClient + Polly**  
  Resiliência, retry e controle de falhas na coleta de dados.
* **JSON / CSV / APIs REST** (fontes de dados)

---

### 🏗️ Como rodar o projeto

#### 1. Instale o .NET SDK

Recomendado **.NET 8 ou superior**:

👉 https://dotnet.microsoft.com/download

---

#### 2. Instale o workload do .NET MAUI

```bash
dotnet workload install maui
```

#### 3. Clone o repositório

```bash
git clone https://github.com/seu-usuario/DataFlow.git
cd DataFlow
```

---

#### 4. Execute a aplicação

No Windows:

```bash
dotnet build -t:Run -f net9.0-windows10.0.19041.0
```

Ou simplesmente abra o projeto no **Visual Studio 2022+** e selecione a plataforma desejada.

---

### 🧪 Testes

Caso o projeto utilize **testes automatizados em C#**, eles ficam no diretório:

```
tests/
```

E podem ser executados com:

```bash
dotnet test
```

---

### 🚀 Roadmap (em evolução)

- [ ] Módulos ETL configuráveis por UI
- [ ] Agendamento de coletas
- [ ] Dashboard de status e logs
- [ ] Exportação para banco de dados
- [ ] Suporte a múltiplas fontes simultâneas

---

### 👥 Principais Contribuidores

**Matheus Junqueira da Silva**  
👨‍💻 Desenvolvedor de Software • Especialista em ETL

**Gerson Augusto Mendonça**  
👨‍💻 Analista e Desenvolvedor

---

### 📄 Licença

Este projeto está sob a licença **Licença Proprietária** (ou outra, se aplicável).  
Consulte o arquivo `LICENSE` para mais detalhes.

