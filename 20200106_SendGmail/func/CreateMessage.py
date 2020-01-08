#!/usr/bin/python
# -*- Coding: utf-8 -*-
from func import ImportData
import numpy as np


class CreateMessage():
    def __init__(self, header_sentence):
        self.header_sentence = header_sentence

    def get_message(self, id, attendance_df):
        # 警告対象のデータを抜き出し
        target_attendance_data = attendance_df[(attendance_df["id"] == id) & (attendance_df["warning_flg"] == 1)]
        # メッセージを作成
        message = self.__convert_dataframe_to_string(target_attendance_data)
        return message

    def __convert_dataframe_to_string(self, dataframe):
        resultString = []
        resultString.append(self.header_sentence)
        for value in np.array(dataframe):
            resultString.append(','.join(map(str, value)))
        return "\n".join(resultString)

if __name__ == "__main__":
    importData = ImportData.ImportData()
    attendance_df = importData.import_data("Attendance_Information.csv")

    createMessage = CreateMessage( "対象の勤怠は以下の通りです。")
    createMessage.get_message("H001", attendance_df)