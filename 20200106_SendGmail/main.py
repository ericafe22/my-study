#!/usr/bin/python
# -*- Coding: utf-8 -*-
import logging

from func import GetFilePath
from func import ImportData
from func import ExtractTargetUser
from func import CreateMessage
from func import SendMail

class Main():
    def __init__(self):
        getFilePath = GetFilePath.GetFilePath()

    def execute_main(self):

        # データのインポート
        importData = ImportData.ImportData()

        attendance_df = importData.import_data("Attendance_Information.csv")
        mail_df = importData.import_data("mail_master.csv")

        # アドレス帳の作成
        extractTargetUser = ExtractTargetUser.ExtractTargetUser()
        send_target_user_df = extractTargetUser.create_target_user_df(attendance_df, mail_df)

        # メッセージ作成&送信処理
        for index, row in send_target_user_df.iterrows():
            logging.info("ID: " + row.id + "USER: " + row.full_name)

            # 本文の作成
            createMessage = CreateMessage.CreateMessage("対象の勤怠は以下の通りです。")
            message = createMessage.get_message(row.id, attendance_df)

            # メールの送信
            sendMail = SendMail.SendMail()
            sendMail.send_mail(message, row.mail)

        logging.info("finish")


if __name__ == "__main__":
    main = Main()
    main.execute_main()
