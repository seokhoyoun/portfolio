---
name: "[L사] 디스플레이 라인 전후 공정 연계"
title: "[L사] 디스플레이 라인 전후 공정 연계"
company: "제이원소프트"
layout: page
tools: ["C#", "WinForms", "MS-SQL", "DevExpress"]
description: 디스플레이 공정별 Defect 데이터 수집 및 Parser 툴 개발.
---
## 프로젝트 개요
L사 디스플레이 라인의 전후 공정 데이터를 연계하여 결함(Defect) 정보를 효율적으로 매칭하고 분석하는 프로젝트입니다. 공정 간 데이터 흐름을 안정적으로 연결하고, 사용자에게 명확한 시퀀스와 화면 구성을 제공하는 데 목적을 두었습니다. 특히 고객의 요구사항을 충족하는 Export 중심 흐름과 분석 목적을 모두 만족하도록 화면과 로직을 설계했습니다.
  
![Home ??]({{ "/assets/images/projects/lg-display-home.png" | relative_url }})

## 프로그램 시퀀스 

1. 패널 아이디 입력 (1~n)
2. FTP 서버에서 Cell Index / Cell Defect / Module Index / Module Defect 다운로드
3. Local / Cell Defect / Module Defect 매칭
4. 사용자 Feature 선택
5. Export
  
![Flaw map ??]({{ "/assets/images/projects/lg-display-flaw.png" | relative_url }})

## 화면 및 연동 구성
- Home 페이지: 패널 아이디 입력, 매칭 프로세스 시작, 결과 요약 표시
- Flaw map 페이지: 인덱스 파일 경로 내 모든 Defect 파일을 활용하여 시각화 및 비교
- Analyze 페이지: 분석 목적의 결과 검토(현재는 PRI 내부 목적에 한정)

Flaw map은 Index 파일 내 모든 경로에 접근하여 Defect 파일을 활용해야 하며, Home → Flaw map → Analyze 순으로 자연스럽게 이어지는 흐름을 목표로 했습니다.

## 주요 요구사항 정리
  - Export 결과 데이터가 핵심이며, Flaw map / Analyze 페이지는 보조 역할을 합니다.
  - Feature 선택 분석을 위해 Flaw map 페이지 활용이 필수입니다.
  - 매칭 이후 Flaw map으로 연동되어야 함
  - Flaw map 페이지는 인덱스 파일 내 모든 경로의 Defect 파일을 활용해야 함

![Analyze ??]({{ "/assets/images/projects/lg-display-analyze.png" | relative_url }})

## Overview
- 기간: 2022.01 ~ 2022.09 (약 8개월)
- 소속: 제이원소프트
- 역할: 개발 및 셋업
- 주요 업무: 공정 데이터 수집/파싱 도구 구현
