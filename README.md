# Frogger Clone (Unity Learning Project)

Este é um projeto simples desenvolvido como um exercício de aprendizado para entender os fundamentos do motor de jogo Unity e da linguagem C#. Trata-se de uma recriação básica da mecânica do clássico jogo Frogger.

## Visão Geral

O objetivo principal deste projeto não foi criar um jogo completo ou polido, mas sim focar na implementação de mecânicas essenciais, como:

*   Movimentação do jogador.
*   Movimentação de obstáculos (simulando carros e troncos).
*   Detecção de colisão.
*   Condições de vitória e derrota simples.

**Importante:** Este projeto utiliza placeholders visuais ou formas geométricas simples. O foco não foi em gráficos ou design visual, mas puramente na lógica de programação e na familiarização com o ambiente Unity.

## Mecânicas Implementadas

*   **Movimento do Jogador:** O jogador pode se mover para cima, baixo, esquerda e direita, um "passo" por vez.
*   **Obstáculos em Movimento:**
    *  Objetos que se movem horizontalmente e causam a derrota do jogador ao serem tocados.
*   **Zonas Seguras/Objetivos:** Áreas designadas onde o jogador deve chegar para "vencer" (ou completar um nível).
*   **Morte/Reset:** O jogador é reiniciado ao colidir com um obstáculo
*   **Vidas:** Controle de vidas.
*   **Nível:** Reinício do nível ao vencer/perder.

## O que Aprendi (Objetivos de Aprendizagem)

Durante o desenvolvimento deste projeto, o foco foi em aprender e praticar:

*   Navegação básica no Editor Unity (Scene View, Game View, Hierarchy, Inspector).
*   Criação e manipulação de GameObjects e seus Componentes.
*   Scripting em C# para Unity:
    *   Receber input do jogador (`Input.GetKeyDown`).
    *   Movimentar GameObjects (`Transform.Translate`, manipulação de `Vector2`).
    *   Lógica de colisão (`OnTriggerEnter`, `OnCollisionEnter`, Layers, Tags).
    *   Instanciação e destruição de GameObjects (se aplicável).
    *   Organização básica de scripts.
*   Uso de Prefabs para obstáculos e jogador.
*   Configuração de Câmera básica.
*   Entendimento do ciclo de vida de scripts do Unity (Awake, Start, Update).

## Como Executar

1.  Clone este repositório.
2.  Abra o Unity Hub.
3.  Clique em "Add" ou "Open" e navegue até a pasta raiz do projeto clonado.
4.  Selecione a versão correta do Unity Editor (se solicitado, idealmente a mesma usada no desenvolvimento, ex: `202X.X.Xf1`).
5.  Uma vez que o projeto estiver aberto no Unity Editor, localize a cena principal (provavelmente em `Assets/Scenes/`) e abra-a.
6.  Pressione o botão "Play" no topo do editor.

---