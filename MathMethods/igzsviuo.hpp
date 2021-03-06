﻿<Window x:Class="MathMethods.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MathMethods" Height="490" Width="697">
    <Grid>
        <Menu HorizontalAlignment="Left" Height="auto" VerticalAlignment="Top" Width="689">
            <MenuItem Header ="File">
                <MenuItem Header="Exit" Click="MenuExit_Click"/>
            </MenuItem>
            <MenuItem Header="About" Click="MenuItem_Click"></MenuItem>
        </Menu>
        <TabControl HorizontalAlignment="Left" Height="441" Margin="0,18,0,0" VerticalAlignment="Top" Width="689">
            <TabItem Header="Fibonacci">
                <Grid Background="#FFE5E5E5">
                    <Button x:Name="SlvBtn" Content="Solve" HorizontalAlignment="Left" Margin="5,276,0,0" VerticalAlignment="Top" Width="323" Click="SlvBtn_Click" Height="33"/>
                    <Label Content="x =" HorizontalAlignment="Left" Margin="10,184,0,0" VerticalAlignment="Top"/>
                    <Label Content="y =" HorizontalAlignment="Left" Margin="10,213,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblX" Content="" HorizontalAlignment="Left" Margin="28,184,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblY" Content="" HorizontalAlignment="Left" Margin="28,215,0,0" VerticalAlignment="Top"/>
                    <Label Content="Iterations:" HorizontalAlignment="Left" Margin="10,244,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblIterations" Content="" HorizontalAlignment="Left" Margin="77,245,0,0" VerticalAlignment="Top"/>
                    <Label Content="Choose function: " HorizontalAlignment="Left" VerticalAlignment="Top" Margin="10,14,0,0"/>
                    <ComboBox x:Name="cmboxFunc" HorizontalAlignment="Left" Margin="117,16,0,0" VerticalAlignment="Top" Width="174" Height="22" Loaded="ComboBox_Loaded"/>
                    <Label Content="eps =" HorizontalAlignment="Left" Margin="10,140,0,0" VerticalAlignment="Top"/>
                    <Label Content="a =" HorizontalAlignment="Left" Margin="10,77,0,0" VerticalAlignment="Top"/>
                    <Label Content="b =" HorizontalAlignment="Left" Margin="10,109,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblEps" Content="" HorizontalAlignment="Left" Margin="50,141,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblA" Content="" HorizontalAlignment="Left" Margin="35,77,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblB" Content="" HorizontalAlignment="Left" Margin="39,109,0,0" VerticalAlignment="Top"/>
                    <GroupBox Header="Answer" HorizontalAlignment="Left" Margin="5,172,0,0" VerticalAlignment="Top" Height="99" Width="323"/>
                    <GroupBox Header="Initial data" HorizontalAlignment="Left" VerticalAlignment="Top" Height="174" Width="323" Margin="5,0,0,0"/>
                    <Label Content="F =" HorizontalAlignment="Left" Margin="10,49,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="lblFunc" Content="" HorizontalAlignment="Left" Margin="39,49,0,0" VerticalAlignment="Top"/>

                </Grid>
            </TabItem>
            <TabItem Header="Cubic  Approximation">
                <Grid Background="#FFE5E5E5">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition/>
                        <ColumnDefinition Width="0*"/>
                    </Grid.ColumnDefinitions>
                    <Button x:Name="btnCubicApp" Content="Solve" HorizontalAlignment="Left" Margin="5,276,0,0" VerticalAlignment="Top" Width="323" Click="btnCubicApp_Click" Height="33"/>
                    <ComboBox x:Name="cmbBox_Cubic" HorizontalAlignment="Left" Margin="117,16,0,0" VerticalAlignment="Top" Width="174"  Height="22" Loaded="cmbBox_Cubic_Loaded"/>
                    <Label Content="Choose function:" HorizontalAlignment="Left" Margin="10,14,0,0" VerticalAlignment="Top" Height="26" Width="99"/>
                    <Label Content="F =" HorizontalAlignment="Left" Margin="10,49,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblFunc_Cubic" Content="" HorizontalAlignment="Left" Margin="42,49,0,0" VerticalAlignment="Top" />
                    <Label Content="a =" HorizontalAlignment="Left" Margin="10,77,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblA_Cubic" Content="" HorizontalAlignment="Left" Margin="42,77,0,0" VerticalAlignment="Top" />
                    <Label Content="b =" HorizontalAlignment="Left" Margin="10,109,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblB_Cubic" Content="" HorizontalAlignment="Left" Margin="42,109,0,0" VerticalAlignment="Top" />
                    <Label Content="eps =" HorizontalAlignment="Left" Margin="10,140,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblEPS_Cubic" Content="" HorizontalAlignment="Left" Margin="42,140,0,0" VerticalAlignment="Top" />
                    <Label Content="x =" HorizontalAlignment="Left" Margin="10,184,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblX_Cubic" Content="" HorizontalAlignment="Left" Margin="44,184,0,0" VerticalAlignment="Top" />
                    <Label Content="y =" HorizontalAlignment="Left" Margin="10,213,0,0" VerticalAlignment="Top" Height="26" Width="38"/>
                    <Label x:Name="lblY_Cubic" Content="" HorizontalAlignment="Left" Margin="44,213,0,0" VerticalAlignment="Top" />
                    <GroupBox Header="Answer" HorizontalAlignment="Left" Margin="5,174,0,0" VerticalAlignment="Top" Height="97" Width="323"/>
                    <GroupBox Header="Initial data" HorizontalAlignment="Left" VerticalAlignment="Top" Height="174" Width="323" Margin="5,0,0,0"/>
                    <Label Content="Iterations =" HorizontalAlignment="Left" Margin="10,239,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="iter_lbl" Content="" HorizontalAlignment="Left" Margin="81,239,0,0" VerticalAlignment="Top"/>
                </Grid>
            </TabItem>

            <TabItem Header="Hooke — Jeeves">
                <Grid Background="#FFE5E5E5">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="288*"/>
                        <ColumnDefinition Width="395*"/>
                    </Grid.ColumnDefinitions>
                    <Button Content="Solve" HorizontalAlignment="Left" Margin="10,253,0,0" VerticalAlignment="Top" Width="253" Click="Button_Click" Height="42"/>
                    <TextBox x:Name="eps_txt_box" HorizontalAlignment="Left" Height="23" Margin="93,70,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="0,0001"/>
                    <TextBox x:Name="delta_txt_box" HorizontalAlignment="Left" Height="23" Margin="197,47,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="66" Text="0,001" Visibility="Hidden"/>
                    <TextBox HorizontalAlignment="Left" Height="23" Margin="10,140,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="1"/>
                    <TextBox HorizontalAlignment="Left" Height="23" Margin="143,140,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="1"/>
                    <TextBox x:Name="txt_box2" HorizontalAlignment="Left" Height="23" Margin="147,199,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="116" Text="0"/>
                    <TextBox x:Name="txt_box3" HorizontalAlignment="Left" Height="23" Margin="197,199,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="66" Text="0" Visibility="Hidden"/>
                    <TextBox x:Name="txt_box1" HorizontalAlignment="Left" Height="23" Margin="10,199,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="0"/>
                    <Label Content="Точность" HorizontalAlignment="Left" Margin="10,67,0,0" VerticalAlignment="Top"/>
                    <Label Content="Координатные направления" HorizontalAlignment="Left" Margin="63,109,0,0" VerticalAlignment="Top"/>
                    <Label Content="Начальное приближение" HorizontalAlignment="Left" Margin="63,168,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="label_answ" Content="" Grid.Column="1" HorizontalAlignment="Left" Margin="101,29,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="label_func_value" Content="" Grid.Column="1" HorizontalAlignment="Left" Margin="101,60,0,0" VerticalAlignment="Top"/>
                    <Label x:Name="num_iter" Content="" Grid.Column="1" HorizontalAlignment="Left" Margin="101,95,0,0" VerticalAlignment="Top"/>
                    <ComboBox x:Name="cmbbox_hooke" HorizontalAlignment="Left" Margin="93,33,0,0" VerticalAlignment="Top" Width="120" Loaded="cmbbox_hooke_Loaded"/>
                    <Label Content="Функция" HorizontalAlignment="Left" Margin="10,29,0,0" VerticalAlignment="Top"/>
                    <GroupBox Header="Входные данные" HorizontalAlignment="Left" VerticalAlignment="Top" Height="306" Width="291" Margin="268,19,0,0" Grid.ColumnSpan="2"/>
                    <Label Content="Точка min:" Grid.Column="1" HorizontalAlignment="Left" Margin="29,29,0,0" VerticalAlignment="Top"/>
                    <Label Content="Функция:" Grid.Column="1" HorizontalAlignment="Left" Margin="29,60,0,0" VerticalAlignment="Top"/>
                    <Label Content="Итераций:" Grid.Column="1" HorizontalAlignment="Left" Margin="29,95,0,0" VerticalAlignment="Top"/>
                    <GroupBox Grid.Column="1" Header="Выходные данные" HorizontalAlignment="Left" Margin="3,0,0,0" VerticalAlignment="Top" Height="306" Width="382"/>
                </Grid>
            </TabItem>

            <TabItem Header="Rosenbrock">
                <Grid Background="#FFE5E5E5">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="288*"/>
                        <ColumnDefinition Width="395*"/>
                    </Grid.ColumnDefinitions>
                </Grid>
            </TabItem>

            <TabItem Header="Graph" HorizontalAlignment="Left" Height="20" VerticalAlignment="Top" Width="55">
                <Grid Background="#FFE5E5E5">
                    <Canvas Background="White" x:Name="canvasGraph" HorizontalAlignment="Left" Height="333" Margin="0,80,0,0" VerticalAlignment="Top" Width="683"/>
                    <TextBox x:Name="functionTextBox" HorizontalAlignment="Left" Height="23" Margin="256,55,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="336"/>
                    <Button x:Name="btnPlot" Content="Draw" HorizontalAlignment="Left" Margin="599,55,0,0" VerticalAlignment="Top" Width="75" Height="23" Click="btnPlot_Click"/>
                    <Label Content="X-axis:" HorizontalAlignment="Left" Margin="10,0,0,0" VerticalAlignment="Top"/>
                    <Label Content="Y-axis:" HorizontalAlignment="Left" Margin="10,26,0,0" VerticalAlignment="Top"/>
                    <TextBox x:Name="XFromTextBox" HorizontalAlignment="Left" Height="23" Margin="59,3,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="57"/>
                    <TextBox x:Name="YFromTextBox" HorizontalAlignment="Left" Height="23" Margin="59,29,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="57"/>
                    <TextBox x:Name="XToTextBox" HorizontalAlignment="Left" Height="23" Margin="131,3,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="57"/>
                    <TextBox x:Name="YToTextBox" HorizontalAlignment="Left" Height="23" Margin="131,29,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="57"/>
                    <Label Content="Step:" HorizontalAlignment="Left" Margin="10,51,0,0" VerticalAlignment="Top"/>
                    <TextBox x:Name="StepTextBox" HorizontalAlignment="Left" Height="23" Margin="59,55,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="129"/>
                    <Label Content="Function:" HorizontalAlignment="Left" Margin="200,52,0,0" VerticalAlignment="Top"/>
                </Grid>
            </TabItem>
        </TabControl>

    </Grid>
</Window>
