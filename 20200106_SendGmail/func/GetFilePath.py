#!/usr/bin/python
# -*- Coding: utf-8 -*-
import os

class GetFilePath():
    def __init__(self):
        self.current_path = os.path.dirname(os.path.dirname(os.path.abspath(__file__))).replace('\\', '/')

    def get_current_path(self):
        return self.current_path

    def get_setting_path(self):
        return os.path.join(self.current_path, "setting.ini")

    def get_resource_path(self):
        return os.path.join(self.current_path, "Resource").replace('\\', '/')

if __name__ == "__main__":
    GetFilePath = GetFilePath()
    print(GetFilePath.get_resource_path())
    print()
    print(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))