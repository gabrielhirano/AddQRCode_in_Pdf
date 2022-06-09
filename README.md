# Adicionando qrCode com C#
Projeto desenvolvido utilizando ambiente .NET
Foi utilizado as seguintes biliotecas

Zxing para manipular o QRCode
ItextSharp para manipulação do arquivo

O problema que o projeto procura solucionar é adicionar um QRCode numa parte especifica de um arquivo PDF, sendo essa parte variavel, nao podendo adicionar com posição absoluta.
Entao tive que mapear o arquivo e adicionar cordenadas para cada cadeia de caracteres encontrada
No fim o parametro de busca, procura a cadeia escolhida pela pessoa, eu defini essa cadeia, como __QRCODE__

A biblioteca do ZXING transforma um link em um Qrcode

Mas o que gostei desse projeto foi trabalhar com tudo em memoria manipulando o arquivo e o qrcode como um Vetor tipo Byte

Projeto  Acima recebe um arquivo Zip com Pdfs dentro, descompacta em memoria cada arquivo é mandado para uma segunda rotina na qual adiciona o QrCode, e ao final ele zipa novamente os pdfs, ou concatena todos em 1.
