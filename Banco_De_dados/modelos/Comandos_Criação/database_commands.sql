CREATE TABLE USUARIO (
    EMAIL VARCHAR(20) PRIMARY KEY UNIQUE,
    NOME VARCHAR(15) UNIQUE
);

CREATE TABLE TECNICO (
    ID INT PRIMARY KEY UNIQUE,
    NOME VARCHAR(15) UNIQUE,
    LOGIN VARCHAR(8),
    SENHA VARCHAR(8),
    STATUS VARCHAR(12)
);

CREATE TABLE NOTIFICACAO (
    ID INT PRIMARY KEY UNIQUE,
    NUM_INCIDENTE INT UNIQUE,
    PATRIMONIO_MAQ VARCHAR(10) UNIQUE,
    REG_DATA_HOR DATE UNIQUE
);

CREATE TABLE ATENDIMENTO (
    ID_ATENDIMENTO int PRIMARY KEY,
    USUARIO_NOME VARCHAR(20),
    USUARIO_EMAIL VARCHAR(15),
    TECNICO_ID INT,
    TECNICO_NOME VARCHAR(15),
    ID_NOTIFICACAO INT,
    NUM_INCIDENTE INT,
    PATRIMONIO_MAQ VARCHAR(10),
    REG_DATA_HOR DATE
);

CREATE TABLE ATENDE (
    FK_TECNICO_ID INT,
    FK_NOTIFICACAO_ID_NOTIFICACAO INT
);

CREATE TABLE GERA (
    FK_USUARIO_Email VARCHAR(20),
    FK_NOTIFICACAO_ID_NOTIFICACAO INT
);
 
ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_1
    FOREIGN KEY (USUARIO_NOME)
    REFERENCES USUARIO (NOME)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_2
    FOREIGN KEY (USUARIO_EMAIL)
    REFERENCES USUARIO (EMAIL)
    ON DELETE RESTRICT;
 

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_3
    FOREIGN KEY (TECNICO_ID)
    REFERENCES TECNICO (ID)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_4
    FOREIGN KEY (TECNICO_NOME)
    REFERENCES TECNICO (NOME)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_5
    FOREIGN KEY (ID_NOTIFICACAO)
    REFERENCES NOTIFICACAO (ID)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_6
    FOREIGN KEY (NUM_INCIDENTE)
    REFERENCES NOTIFICACAO (NUM_INCIDENTE)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_7
    FOREIGN KEY (PATRIMONIO_MAQ)
    REFERENCES NOTIFICACAO (PATRIMONIO_MAQ)
    ON DELETE RESTRICT;

ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ATENDIMENTO_8
    FOREIGN KEY (REG_DATA_HOR)
    REFERENCES NOTIFICACAO (REG_DATA_HOR)
    ON DELETE RESTRICT;





ALTER TABLE ATENDE ADD CONSTRAINT FK_ATENDE_1
    FOREIGN KEY (FK_TECNICO_ID)
    REFERENCES TECNICO (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE ATENDE ADD CONSTRAINT FK_ATENDE_2
    FOREIGN KEY (FK_NOTIFICACAO_ID_NOTIFICACAO)
    REFERENCES NOTIFICACAO (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE GERA ADD CONSTRAINT FK_GERA_1
    FOREIGN KEY (FK_USUARIO_Email)
    REFERENCES USUARIO (Email)
    ON DELETE RESTRICT;
 
ALTER TABLE GERA ADD CONSTRAINT FK_GERA_2
    FOREIGN KEY (FK_NOTIFICACAO_ID_NOTIFICACAO)
    REFERENCES NOTIFICACAO (ID)
    ON DELETE RESTRICT;