   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	   !    CourseManagement.AddStudent   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  
AddStudent��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Add Students��6   $��Center=�6'   $��30��6D   $��0,10,0,0q�6P   $	��Top=�6b   $	��100��6z   �� 5   
   $��Student Name: ��6   $
��Left=�6)   $��32��6D   $��
128,47,0,0q�6P   $	��Top=�6d   $��98��6|   �� 5   
   $��Birthdate: ��6   $
��Left=�6&   $��27��6A   $��
134,84,0,0q�6M   $	��Top=�6a   $��88��6y   �� 5   
   $��Gender: ��6   $
��Left=�6#   $��31��6>   $��133,126,0,0q�6J   $	��Top=�6_   $��76��6w    J� RenderTransformOrigin$ 0.515,0.906&�6�   �� 5   
   $��	Address: ��6   $
��Left=�6$   $��32��6?   $��130,162,0,0q�6K   $	��Top=�6`   $��76��6x   �� 5   
   $��City: ��6   $
��Left=�6!   $��27��6<   $��	134,0,0,0q�6H   $��Center=�6[   $��70��6v   �� 5   
   $��	Country: ��6   $
��Left=�6$   $��28��6?   $��130,253,0,0q�6K   $	��Top=�6`   $��66��6x   �� 5   
   $��Department: ��6   $
��Left=�6'   $��25��6B   $��122,299,0,0q�6N   $	��Top=�6c   $��82��6{   $ 0.576,-3.169&�6�   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��18��6>   $��
276,45,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��294��6�   �� 5   
   -   5        $ 
txtAddress��5      $
��Left=�6&   $��18��6A   $��276,162,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��294��6�   �� 5   
   -   5        $ txtCity��5      $
��Left=�6#   $��18��6>   $��276,204,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��294��6�   �� 5   
   -   5        $ 
txtCountry��5      $
��Left=�6&   $��18��6A   $��276,253,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��294��6�   �� 5   
   -   5        $��Add Student��5      $
��Left=�6'   $��31��6B   $��373,369,0,0q�6N   $	��Top=�6c   $	��100��6{   6�   �� 5   
   -   5         ��Name$ cboDepartment��5      $
��Left=�6*   $��23��6E   $��276,301,0,0q�6Q   $	��Top=�6f   $	��294��6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtBirthDate��5      $
��Left=�6a   $��27��6|   $��
276,84,0,0q�6�   $	��Top=�6�   $	��294��6�   �� 5   
   -   5        $ 	cboGender��5      $
��Left=�6&   $��26��6A   $��276,126,0,0q�6M   $	��Top=�6b   $	��294��6z   5      5      