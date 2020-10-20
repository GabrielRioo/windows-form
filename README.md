# Windows Form Application  
### Youtube: [CFBCursos](https://www.youtube.com/watch?v=UZdEkx-Z-7g)
~[Aula 61](https://www.youtube.com/watch?v=UZdEkx-Z-7g)~ ~[Aula 68](https://www.youtube.com/watch?v=FKKbjTR4758)~ [81](https://www.youtube.com/watch?v=YsthjKVNVSA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=81)
<br>
* Por padrão os componentes vem como **Private**
## Atalhos:
* F7 - No formsDesign, precionando F7, abre o codigo.
* Shift + F7 - No codigo, abre o formsDesign

## Ferramentas: 
* **DataTimePicker** - Calendario(em texto)
* **MounthCalendar** - Calendário(visual, imagem com os dias)
   * .SelectionRange (o range desde o startDay até o endDay)
   * .SelectionStart - Dia Inicial
   * .SelectionEnd - Dia Final
   * .SelectionStart.ToShortTimeString() - Pega as horas
   * .SelectionStart.ToShortDateString() - Pega a data (dia, mes e ano)
   * .TodayDate.ToString() - Pega a data e hora atual
* Label - Texto
* Button - Botão
* **ChekedListBox** - Lista de Checklist
* **ComboBox** - DropDown
* ListBox - parecido com o ComboBox porem mostra todos, nao tem um dropdown
* LinkLabel - Link para sites externos
* TextBox - Input para escrever
* ListView - tipo de tabela
   * Edit Collumns - adicionar as colunas, com nome e texto
   * Edit Itens - adicionar linhas
      * Adicionar a primeira coluna da Tabela.
      * Para adicionar as outras colunas: 
         * Dados/ SubItems 
         * Adicionar
         * Escrever o nome no "Text"
         * Adicionar... Até completetar os itens da tabela
   * Para exibir a tabela: exibição ->  Details
   * FullRowSelect: true - seleciona a linha toda ao clicar
   * MultSelect: true - Permite selecionar mais do que um elemento
* **MaskedTextBox** - mascara para Senha, Cep, numero, data...
   * PasswordChar - "algum caracter" - para ser a senha
   * TextMarkFormat:
      * IncludeLiterals: inclui os caracteres especiais
      * ExcludePromptAndLiterals: não inclui os caracteres especiais
* **NotifyIcon** - 
     * Selecionar um `Icon` a Visible = True
     * ContextMenuStrip - Nome do ContextMenuStrip criado.
* **ContextMenuStrip**
     * Dados/ Items:
     * Evento: ItemClicked - Quando um item for clicado.
* **NumericUpDown** - Area de texto numérica, com setas para incrementar/decrementar
* **PictureBox** - Serve para adicionar uma imagem 
* **ProgressBar** - Barra de Progresso
* **RadioButton** - Radio Button (selecionar apenas um)
* **GroupBox** - Cria um grupo para destinguir funções, como do radio button
* **RichTextBox** - 

## Arquivo de Recursos:
* Properties/Resourses.resx(clique duplo)
   * A Vantagem de utilizar isso é que ao usar isso bastante no programa, ao alterar no "Arquivo de Recursos" irá alterar em todos os lugares que estiverem chamando esssa propriedade.

## Propriedades:
### Para o Form:
* **Appearance**
   * FormBorderStyle - FixedDialog - Não tem como redimencionar a janela
* **Window Style/ Icon**
   * MaximizeBox - False- Não permite deixar em tela cheia
* **CheckedListBox/ Data**
   * Items - Adicionar itens
* **ListView / Aparencia**
   * FullRowSelect: true - seleciona a linha toda ao clicar
   * MultSelect: true - Permite selecionar mais do que um elemento
   
### Componentes:
* **Behaviors**
   * ReadOnly - True (somente leitura), False(pode escrever)
* **Layout**
   * StratScree: Center - centraliza a tela no meio do monitor ao abrir
* **Design**
   * (Name) - Nome do componente/método
   * Modifiers - Visibilidade do Objeto: public, private...

### Métodos: (todos podem ser contultados na propriedade de cada componente)
* `.Clean();` - Limpa o conteudo ali dentro
* `**Checked List Box**`
   * `.Items.Clear();` - Limpa os Itens de um **Checked List Box**
   * `.Items.Add(object, bool);` - Adiciona um item
* `.Focus();` - Poe em foco o conteudo 
* `MessageBox.Show(string);` - Abre um textbox na tela com mensagem digitada.
* `.ShowDialog();` - Após instacia um objeto do novo Form, esse método mostrará a nova tela. _Não permite clicar nas janelas anteriores._
* `.Show();` - Após instacia um objeto do novo Form, esse método mostrará a nova tela. _Permite que clique e deixe em focus a janela anterior._
* `.Checked` - Ve se está checado.
* `.Links[2].Enabled = false; -` Desabilita um dos multiplos links
* `.DataSource` - propriedade do **ListaBox & comboBox** para associar um elemento a uma fonte de dados


### Eventos / Funções:
* **Behaviors**
   * FormClosed - Quando formulário for fechado.
   * SelectedIndexchanged - quando for alterado o item da tabela
* **Misc**
   * CheckedChanged - Usado para quando o checkbox for marcado mostrar/acontecer algo.
* 
