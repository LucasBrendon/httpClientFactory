# Projeto C# com HttpClient Factory, Retry Pattern e Circuit Breaker usando Polly

<h2>Descrição do Projeto</h2>
<p>Este projeto em C# tem como objetivo demonstrar as boas práticas de comunicação com serviços HTTP, destacando o uso do HttpClient Factory, Retry Pattern e Circuit Breaker com a biblioteca Polly. Essas técnicas são fundamentais para melhorar a resiliência e a confiabilidade de sistemas que dependem de comunicação com APIs externas.</p>
<p>Para este projeto foi utilizada API gratuita da ViaCep na qual a documentação encontra-se no seguinte link: https://viacep.com.br/</p>

Funcionalidades
HttpClient Factory : Utilize o HttpClient Factory para criar instâncias de HttpClient de forma eficiente, gerenciando automaticamente a vida útil das instâncias e proporcionando uma abordagem mais segura e performática para comunicação HTTP.

Retry Pattern : Implementa um padrão de repetição de transações em caso de atrasos temporários. Configurado com Polly, o sistema realiza automaticamente novos testes de solicitação em caso de falha, melhorando a robustez contra falhas transitórias.

Circuit Breaker : Aplique o padrão de Circuit Breaker para evitar interrupções contínuas a um serviço que está experimentando falhas persistentes. O Polly gerencia o estado do disjuntor, permitindo a retomada automática das interrupções quando a situação melhora.
