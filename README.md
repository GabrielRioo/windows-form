# Windows Form Application  
### Youtube: [CFBCursos](https://www.youtube.com/watch?v=UZdEkx-Z-7g)
~[Aula 61](https://www.youtube.com/watch?v=UZdEkx-Z-7g)~ [Aula 68](https://www.youtube.com/watch?v=FKKbjTR4758)
<br>
* Por padrão os componentes vem como **Private**
## Atalhos:
* F7 - No formsDesign, precionando F7, abre o codigo.
* Shift + F7 - No codigo, abre o formsDesign

## Propriedades:
### Para o Form:
* **Appearance**
   * FormBorderStyle - FixedDialog - Não tem como redimencionar a janela
* **Window Style/ Icon**
   * MaximizeBox - False- Não permite deixar em tela cheia
* **CheckedListBox/ Data**
   * Items - Adicionar itens
   
### Componentes:
* **Behaviors**
   * ReadOnly - True (somente leitura), False(pode escrever)
* **Layout**
   * StratScree: Center - centraliza a tela no meio do monitor ao abrir
* **Design**
   * (Name) - Nome do componente/método
   * Modifiers - Visibilidade do Objeto: public, private...

### Métodos:
* .Clean(); - Limpa o conteudo ali dentro
* **Checked List Box**
   * .Items.Clear(); - Limpa os Itens de um **Checked List Box**
   * .Items.Add(object, bool); - Adiciona um item
* .Focus(); - Poe em foco o conteudo 
* MessageBox.Show(string); - Abre um textbox na tela com mensagem digitada.
* .ShowDialog(); - Após instacia um objeto do novo Form, esse método mostrará a nova tela. _Não permite clicar nas janelas anteriores._
* .Show(); - Após instacia um objeto do novo Form, esse método mostrará a nova tela. _Permite que clique e deixe em focus a janela anterior._
* .Checked - Ve se está checado.


### Eventos / Funções:
* **Behaviors**
   * FormClosed - Quando formulário for fechado.
* **Misc**
   * CheckedChanged - Usado para quando o checkbox for marcado mostrar/acontecer algo.
