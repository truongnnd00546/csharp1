﻿namespace YangYesterday.entity
{
    public class YYTransaction
    {
        private string _id;
        private decimal _amount;
        private string _content;
        private string _senderAccountNumber;
        private string _receiverAccountNumber;
        private int _type; // 1. withdraw | 2. deposit | 3. transfer.
        private string _createdAt;
        private int _status; // 0. deleted | 1. success | 2.processing.

        public YYTransaction()
        {
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public decimal Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public string Content
        {
            get => _content;
            set => _content = value;
        }

        public string SenderAccountNumber
        {
            get => _senderAccountNumber;
            set => _senderAccountNumber = value;
        }

        public string ReceiverAccountNumber
        {
            get => _receiverAccountNumber;
            set => _receiverAccountNumber = value;
        }

        public int Type
        {
            get => _type;
            set => _type = value;
        }

        public string CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }

        public int Status
        {
            get => _status;
            set => _status = value;
        }
    }
}