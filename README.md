# Student API

API simples para gerenciamento de estudantes, desenvolvida em .NET 8 com Minimal APIs.

### Como Executar

1.  Clone o repositório.
2.  Navegue até a pasta `StudentApi/StudentApi`.
3.  Execute o comando `dotnet run`.

---

### Justificativa das Decisões Técnicas

A arquitetura deste projeto foi escolhida para demonstrar um padrão de desenvolvimento limpo e organizado, mesmo sendo uma API simples. As decisões foram:

1.  **Estrutura em Camadas (Clean Architecture):** Optei por usar Minimal APIs com uma estrutura bem definida (`Domain`, `Application`, `Persistence`, `Api`). Gosto de como isso organiza o código e o torna escalável, separando claramente as responsabilidades. Essa é a forma como tenho estruturado meus projetos no dia a dia.

2.  **Código Desacoplado:** Utilizei o **Padrão de Repositório** e **Injeção de Dependência** para que a lógica de negócio não dependa diretamente do acesso a dados. Isso torna o código mais flexível para futuras mudanças (como trocar o banco de dados) e muito mais fácil de testar.

3.  **Contrato da API com DTOs:** Criei objetos `CreateStudentDto` e `StudentResponseDto` para não expor minhas entidades internas diretamente na API.

4.  **Banco de Dados em Memória:** Para simplificar e agilizar a avaliação do desafio, usei um banco de dados em memória.
   
Em resumo, a intenção foi entregar um projeto que refletisse as boas práticas e o padrão de qualidade que sigo em projetos maiores.

---

### Testes Manuais (Postman)

Todos os endpoints da API foram testados manualmente utilizando o Postman. Seguem prints mostrando as requisições e suas respectivas respostas:

<img width="1372" height="559" alt="image" src="https://github.com/user-attachments/assets/5824ad80-68fb-4bde-ae97-5cd638f0177c" />
<img width="1393" height="811" alt="image" src="https://github.com/user-attachments/assets/5849151c-dd01-4cb1-8fb9-69eeda75d176" />
<img width="1373" height="448" alt="image" src="https://github.com/user-attachments/assets/d45b1d18-9d02-40d4-ba1d-e550e91b73ee" />
<img width="1388" height="507" alt="image" src="https://github.com/user-attachments/assets/738bc7c8-18ae-47de-b25f-0143a629dae6" />
<img width="1390" height="527" alt="image" src="https://github.com/user-attachments/assets/60d897a9-0e03-4d83-b82d-511d2445b8b8" />
