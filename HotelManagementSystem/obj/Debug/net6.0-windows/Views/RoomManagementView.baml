   M S B A M L   `   `   `  ����P  LHotelManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HotelManagementSystem.ViewsHotelManagementSystem.Views  5      4    .HotelManagementSystem.Views.RoomManagementView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:HotelManagementSystem.Views     5      .��5	      � .+�5
   
   � $��
0,0,426,41q�6   .+�5      �� -   5        $��StackPanel_AddRoom��5      $
��Left=�63   $	��217��6N   $��26,0,0,0q�6[   $	��Top=�6m   $	��347��6�   .+�5      �� $��25��6   $
��Wrap=�6(   $��Add Room��6<   $	��132��6L   $��0,10,0,0q�6X     �� TextAlignment$  Center=�6j   $
��Bold"�6�   $��16(�6�   � 5      $��1��6   $��10q�6$   $	��119��60    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $
��Auto �6+   .+�5      �� $��Room number:��6    $	��Top=�64   �� 5      $	��200��6l   $	��Top=�6x   $��	100 0 0 0q�6�   ��6   �� *SelectedRoom.RoomNumber+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��	Room Type��6    $	��Top=�61   $��0 30 0 0q�6I   �� 5      $	��Top=�6j   $��
100 30 0 0q�6�   ��6   �� *SelectedRoom.RoomType+$ PropertyChanged=�6�   �� 5      $��Status��6    $	��Top=�6.   $��0 60 0 0q�6F   �� 5      $
��Left=�6   $��18��6:   $��
100,60,0,0q�6F   $	��Top=�6Z   $	��200��6r   �� 5      $	��Top=�6h   $��
100 60 0 0q�6�   ��6   �� *SelectedRoom.Status+$ PropertyChanged=�6�   �� 5      $��Price��6    $	��Top=�6-   $��0 90 0 0q�6E   �� 5      $	��Top=�6g   $��
100 90 0 0q�6   ��6   �� *SelectedRoom.Price+$ PropertyChanged=�6   5       5!      �� 5"      $��Confirm��6   
��� � �$
��Left=�6]   $��33��6x   $��	150,0,0,0q�6�   $��Center=�6�   $��62��6�   ��6:   �� *ConfirmCommand+6�   �� 5#      $��Cancel��6   $
��Left=�6I   $��33��6d   $��	260,0,0,0q�6p   $��Center=�6�   $��62��6�   ��6'   �� *CancelCommand+6�   5&      5)      5*      