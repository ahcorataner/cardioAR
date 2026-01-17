<p align="center">
  <strong>Universidade Federal do Maranhão</strong><br>
  <strong>Centro de Ciências Exatas e Tecnologias</strong><br>
  <strong>Curso Engenharia da Computação</strong><br>
  <strong>Disciplina: Computação Gráfica</strong><br>
  <strong>Prof. Dr. Haroldo Gomes Barros Filho</strong>
</p>

<hr>

<p align="center">
  <em>Este projeto foi desenvolvido como parte das atividades da disciplina de <strong>Computação Gráfica,</strong> no curso de Engenharia da Computação da Universidade Federal do Maranhão. A proposta consistiu na criação de um aplicativo educacional interativo, e sua culminância — representada pelo desenvolvimento funcional do aplicativo <strong>CardioAR</strong> e pela apresentação desta documentação técnica — corresponde às avaliações de <strong>Nota 2</strong> e <strong>Nota 3</strong> da disciplina.</em>
</p>

<p align="center">
  <img src="docs/imagens/Logo.png" alt="CardioAR Logo" width="250"/>
</p>

<h1 align="center">🫀 CardioAR</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6.0-blue?logo=unity" alt="Unity Badge"/>
  <img src="https://img.shields.io/badge/C%23-Interactive-green?logo=csharp" alt="C# Badge"/>
  <img src="https://img.shields.io/badge/AR%20Foundation-Enabled-orange?logo=augmentedreality" alt="AR Foundation Badge"/>
  <img src="https://img.shields.io/badge/ARCore-Google%20AR-red?logo=google" alt="ARCore Badge"/>
  <img src="https://img.shields.io/badge/Platform-Android-yellow?logo=android" alt="Android Badge"/>
  <img src="https://img.shields.io/badge/License-MIT-lightgrey" alt="License Badge"/>
</p>



---

## 🧠 Sobre o Projeto

**CardioAR** é um aplicativo educacional interativo desenvolvido em **Unity 6,** com foco na **visualização anatômica do coração humano** em 3D e em **realidade aumentada (AR).**
O projeto une **computação gráfica,** **ciência biomédica** e **tecnologia imersiva,** oferecendo uma ferramenta inovadora para o ensino e a difusão científica na área da saúde.

Por meio de uma interface intuitiva e recursos interativos, o usuário pode explorar o coração humano em detalhes, manipulando o modelo 3D com os dedos e posicionando-o em qualquer ambiente físico através da câmera do celular.

---

## 🎯 Objetivo Científico

O coração é um órgão vital e complexo, cuja compreensão anatômica é essencial para profissionais da saúde. O CardioAR foi desenvolvido com os seguintes propósitos:

- Promover o **ensino ativo** da anatomia cardíaca por meio de recursos digitais tridimensionais.
- Permitir **interação direta** com o modelo anatômico, favorecendo a assimilação espacial das estruturas.
- Integrar **realidade aumentada** como ferramenta pedagógica em ambientes acadêmicos e clínicos.
- Apoiar **docentes, discentes e pesquisadores** em atividades de ensino, treinamento e extensão universitária.

---

## ⚙️ Funcionalidades Técnicas

- **Modelo 3D realista** do coração humano, com texturas e proporções anatômicas precisas.
- **Manipulação tátil:** o usuário pode rotacionar, ampliar e mover o coração com gestos na tela.
- **Realidade aumentada:** o coração pode ser posicionado em qualquer superfície física usando a câmera do dispositivo.
- **Painel informativo** com descrições técnicas das estruturas cardíacas.
- **Interface responsiva** com botões de navegação: *Entrar,* *Sair,* *Avançar,* *Estudo Aprofundado.*
- **Modo de estudo aprofundado** com textos explicativos e foco em cada componente anatômico.
- **Compatível com Android** (.apk exportável).
- Preparado para integração com **AR Foundation** e dispositivos XR.

---

## 🛠️ Tecnologias Utilizadas

- **Unity 6:** motor gráfico para desenvolvimento multiplataforma.
- **C#:** linguagem de programação para lógica interativa.
- **TextMeshPro:** biblioteca para renderização de textos científicos.
- **AR Foundation:** framework para realidade aumentada nativa.
- **ARCore:** plataforma do Google para realidade aumentada em dispositivos Android, utilizada para rastreamento espacial e ancoragem de objetos 3D no ambiente físico.
- **Git/GitHub:** controle de versão e colaboração.
- **Pipeline Android Build:** exportação para dispositivos móveis.

---

## 📚 Conteúdo Científico

Cada estrutura cardíaca é acompanhada de uma descrição técnica baseada em literatura biomédica:

- **Átrio direito:** recebe sangue venoso das veias cavas.
- **Átrio esquerdo:** recebe sangue oxigenado das veias pulmonares.
- **Ventrículo direito:** envia sangue para os pulmões pela artéria pulmonar.
- **Ventrículo esquerdo:** bombeia sangue oxigenado para a aorta.
- **Válvula tricúspide:** regula o fluxo entre átrio e ventrículo direitos.
- **Válvula mitral:** regula o fluxo entre átrio e ventrículo esquerdos.
- **Válvula pulmonar:** controla a saída de sangue para os pulmões.
- **Válvula aórtica:** controla a saída de sangue para o corpo.
- **Aorta:** principal artéria sistêmica, distribui sangue oxigenado.
- **Veias cavas:** conduzem sangue venoso ao coração.

---

## 📸 Demonstrações Visuais

### Ambiente de Desenvolvimento
<p align="center">
  <img src="docs/imagens/TelaUnity.png" alt="Ambiente de Desenvolvimento no Unity" width="600"/>
</p>

### Visualização do coração em 3D
<p align="center">
  <img src="docs/imagens/TelaApp2.png" alt="Visualização do coração em 3D" width="600"/>
</p>

### Painel com descrição anatômica
<p align="center">
  <img src="docs/imagens/TelaApp3.png" alt="Painel com descrição anatômica" width="600"/>
</p>

### Interface com estudo aprofundado
<p align="center">
  <img src="docs/imagens/TelaApp4.png" alt="Interface com estudo aprofundado" width="600"/>
</p>

---

## 👥 Público-Alvo

Este projeto é voltado para:

- Estudantes de graduação em medicina, enfermagem e áreas afins.
- Professores de anatomia, fisiologia e ciências biomédicas.
- Profissionais da saúde em formação continuada.
- Pesquisadores em tecnologias educacionais aplicadas à saúde.

---

## 🚀 Como Executar

### Clonar o repositório
```bash
git clone https://github.com/ahcorataner/cardioAR.git
```

### Abrir no Unity
1. Abra o **Unity Hub.**
2. Clique em **Add Project** e selecione a pasta `CardioAR`.
3. Abra o projeto.

### Gerar APK para Android
1. Vá em **File → Build Settings**.
2. Selecione **Android** e clique em **Switch Platform.**
3. Configure em **Player Settings:**
   - Company Name: `ahcorataner`
   - Product Name: `CardioAR`
   - Package Name: `com.ahcorataner.cardioar`
4. Clique em **Build** e gere o arquivo `.apk`.
5. Instale no dispositivo Android.

---

## 📄 Licença

Este projeto está licenciado sob a **MIT License.**
Consulte o arquivo `LICENSE` para mais detalhes.

---

## ✨ Autoria

Desenvolvido por **Renata Costa Rocha (@ahcorataner)**  
Projeto acadêmico e científico com foco em **Educação Médica Interativa.**
```
