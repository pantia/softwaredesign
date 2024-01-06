# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.

import dearpygui.dearpygui as dpg


from doublylinkedlist import doublyLinkedList
from linkedlist import LinkedList

dpg.create_context()

singleList = LinkedList()
doublyList = doublyLinkedList()




def print_button_callback(sender, data):
    dpg.delete_item("listView")
    dpg.add_listbox(items=list, parent="Primary Window", tag="listView")


with dpg.window(tag="Primary Window"):
    radio_button = dpg.add_radio_button(label="radio", items=['SingleLinkedList', 'DoublyLinkedList'], default_value=1)


    def add_button_callback(sender, data):
        print(radio_button.value)


    dpg.add_input_text()

    dpg.add_button(label='Add', callback=add_button_callback)
    dpg.add_button(label='Print', callback=print_button_callback)



dpg.create_viewport(title='LW9', width=600, height=200)
dpg.setup_dearpygui()
dpg.show_viewport()
dpg.set_primary_window("Primary Window", True)
dpg.start_dearpygui()
dpg.destroy_context()
