<h1 align="center">Projeto C# com HttpClientFactory, Retry Pattern e Circuit Breaker utilizando Polly</h1>

<p align="center">
  Este projeto foi desenvolvido em C# para demonstrar boas práticas na comunicação com serviços HTTP, com foco em resiliência e confiabilidade. Ele utiliza três técnicas fundamentais: <strong>HttpClientFactory</strong>, <strong>Retry Pattern</strong> e <strong>Circuit Breaker</strong>, implementadas com a biblioteca <strong>Polly</strong>.
</p>

<p align="center">
  🌐 <a href="https://viacep.com.br" target="blank" rel="noopener noreferrer">Acesse a documentação da API ViaCep aqui</a>
</p>

---

<h2>📝 Descrição do Projeto</h2>

<p>
  Este projeto visa demonstrar como melhorar a comunicação com APIs externas em sistemas C# através de práticas que aumentam a resiliência, como o uso do <strong>HttpClientFactory</strong>, <strong>Retry Pattern</strong> e <strong>Circuit Breaker</strong> com a biblioteca <strong>Polly</strong>.
</p>

<h3>Funcionalidades Principais:</h3>
<ul>
  <li><strong>HttpClientFactory:</strong> Gerenciamento eficiente e seguro das instâncias de <code>HttpClient</code>.</li>
  <li><strong>Retry Pattern:</strong> Repetição automática de requisições em caso de falhas transitórias.</li>
  <li><strong>Circuit Breaker:</strong> Protege o sistema contra falhas persistentes em serviços externos.</li>
  <li><strong>Integração com ViaCep:</strong> Exemplo de consumo de API para consulta de CEP.</li>
</ul>

---

<h2>🛠️ Tecnologias Utilizadas</h2>
<ul>
  <li><strong>C#:</strong> Linguagem de programação principal do projeto.</li>
  <li><strong>Polly:</strong> Biblioteca para implementar padrões de resiliência como Retry e Circuit Breaker.</li>
  <li><strong>HttpClientFactory:</strong> Gerenciamento eficiente de instâncias de <code>HttpClient</code>.</li>
</ul>

---

<h2>🚀 Como Executar o Projeto Localmente</h2>
<ol>
  <li>Clone este repositório:</li>
  <pre><code>git clone https://github.com/LucasBrendon/httpClientFactory.git</code></pre>
  
  <li>Restaure as dependências do projeto:</li>
  <pre><code>dotnet restore</code></pre>
  
  <li>Execute o projeto:</li>
  <pre><code>dotnet run</code></pre>
</ol>

---

<h2>📋 Licença</h2>
<p>Este projeto está sob a licença MIT. Consulte o arquivo <code>LICENSE</code> para mais informações.</p>

---

<p align="center">
  Se você gostou deste projeto, não se esqueça de deixar uma ⭐️ no repositório!
</p>
