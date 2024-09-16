# Aplicativo de Notas

Este é um aplicativo básico de notas desenvolvido usando .NET MAUI. O app permite que os usuários criem, visualizem, salvem e excluam notas usando um arquivo de texto chamado `Notes.txt`, armazenado no diretório de dados do aplicativo.

<img src="https://user-images.githubusercontent.com/74038190/212284115-f47cd8ff-2ffb-4b04-b5bf-4d1c14c0247f.gif" width="1000">

## Funcionalidades

- **Carregar Nota**: Ao iniciar, se `Notes.txt` existir, seu conteúdo é carregado no editor de texto.
- **Salvar Nota**: Salva o texto do editor no `Notes.txt`. Um rótulo exibe o caminho do arquivo e uma mensagem de sucesso é exibida.
- **Excluir Nota**: Exclui `Notes.txt` se existir. O editor e o rótulo são limpos e uma mensagem de sucesso ou erro é exibida com base na existência do arquivo.

## Visão Geral do Código

- **Caminho do Arquivo**: O caminho para o `Notes.txt` é definido no diretório de dados do aplicativo.
- **Inicialização**: Na inicialização, o aplicativo verifica se `Notes.txt` existe e carrega seu conteúdo no editor.
- **Funcionalidade de Salvar**: Quando o botão "Salvar" é clicado, o texto do editor é escrito no `Notes.txt` e uma mensagem de confirmação é exibida.
- **Funcionalidade de Excluir**: Quando o botão "Excluir" é clicado, o aplicativo exclui `Notes.txt` se existir, limpa o editor e exibe uma mensagem apropriada.

## Como Executar

1. Clone o repositório para sua máquina local.
2. Abra o projeto no Visual Studio com suporte ao .NET MAUI.
3. Compile e execute o aplicativo no simulador ou dispositivo.

## Créditos

Desenvolvido por Mateus S. & Guilherme Barros

- GitHub: [Matz-Turing](https://github.com/Matz-Turing)
- GitHub: [guilherme-barros](https://github.com/guilherme-barros)
