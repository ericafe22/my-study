#!/usr/bin/python
# -*- Coding: utf-8 -*-
import os
import pandas as pd
from func import GetFilePath

class ImportData():
    def __init__(self):
        getFilePath = GetFilePath.GetFilePath()
        self.import_path = getFilePath.get_resource_path()

    def import_data(self, file_name):
        return pd.read_csv(os.path.join(self.import_path, file_name)).replace('\\', '/')

if __name__ == "__main__":
    importData = ImportData()
    print(importData.import_data("Attendance_Information.csv"))