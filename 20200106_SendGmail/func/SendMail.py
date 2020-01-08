#!/usr/bin/python
# -*- Coding: utf-8 -*-
import configparser
import smtplib
from email.mime.text import MIMEText
from func import GetFilePath

class SendMail():
    def __init__(self):
        getFilePath = GetFilePath.GetFilePath()

        # 設定情報の取得
        self.setting_path = getFilePath.get_setting_path()
        ini = configparser.ConfigParser()
        ini.read(self.setting_path, 'UTF-8')
        self.from_address = ini['MAIL_INFO']['from_address']
        self.password = ini['MAIL_INFO']['password']
        self.subject = ini['MAIL_INFO']['subject']

    # 送信用Gmailの元を作成
    def __create_mail(self, message):
        msg = MIMEText(message)
        msg['Subject'] = self.subject
        msg['From'] = self.from_address
        msg['To'] = self.to_address
        self.msg = msg

    # メールを送信
    def send_mail(self, message, to_address):
        self.to_address = to_address
        self.__create_mail(message)

        smtpobj = smtplib.SMTP_SSL('smtp.gmail.com', 465, timeout=10)
        smtpobj.login(self.from_address, self.password)
        smtpobj.sendmail(self.from_address, self.to_address, self.msg.as_string())
        smtpobj.close()


if __name__ == "__main__":
    sendMail = SendMail()
    sendMail.send_mail("this is test", "hoge@gmail.com")

