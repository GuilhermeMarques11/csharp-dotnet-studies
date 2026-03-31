## Sales summary

Este é um programa simples em C# que lê um arquivo CSV contendo dados de produtos, calcula o valor total de cada item (preço × quantidade) e gera um novo arquivo de resumo em uma subpasta específica.

## Funcionalidades
- Leitura de Dados: Processa arquivos .csv com campos separados por vírgula.
- Cálculo Automático: Instancia objetos Product para calcular o valor total do estoque por item.
- Organização de Saída: Cria automaticamente uma pasta chamada out no diretório de origem.
- Exportação: Gera um arquivo summary.csv com o nome do produto e o valor total formatado.

## Estrutura de Arquivos
Entrada Esperada
O arquivo de origem deve seguir o formato nome,preço,quantidade:

Cadeira,50.00,3
Monitor,1200.50,2
Teclado,150.00,1
Saída Gerada
O programa criará um arquivo em ./out/summary.csv:

Cadeira, 150.00
Monitor, 2401.00
Teclado, 150.00