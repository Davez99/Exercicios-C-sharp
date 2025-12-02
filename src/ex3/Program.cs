/*
Exercício 3: Cálculo de Aumento Salarial Condicional (Lógica de Negócio)

Objetivo: Desenvolver um programa para calcular o aumento salarial de um funcionário baseado em
dois critérios distintos: tempo de serviço e faixa salarial. O salário mínimo de referência deve ser R$ 1.518,00.

Requisitos:
1. Receber como entrada: Tempo de Serviço (em anos, ex: 1.8) e Salário Bruto (em R$).
2. Calcular o aumento baseado no Tempo de Serviço (Aumento Tempo):
   - Até 2 anos: 2% sobre o salário.
   - Acima de 2 anos a 5 anos: 5% sobre o salário.
   - Acima de 5 anos: 8% sobre o salário.
3. Calcular o aumento baseado na Faixa Salarial (Aumento Salário):
   - Até 1 salário mínimo: 5% sobre o salário.
   - Acima de 1 até 2 salários mínimos: 8% sobre o salário.
   - Acima de 2 até 3 salários mínimos: 10% sobre o salário.
   - Acima de 3 salários mínimos: 0% (Não recebe aumento por salário).
4. O salário final é o Salário Bruto + Aumento Tempo + Aumento Salário.
5. Exibir o resultado detalhado.

EX:
input: 1,8
input: 5313
output: Aumento por tempo de empresa (2%): R$ 106,26
output: Aumento por salário (0%): Não há aumento por salário.
output: Salário Anterior: R$ 5.313,00 | Salário Atual: R$ 5.419,26

Descreva a sua construção.
*/
