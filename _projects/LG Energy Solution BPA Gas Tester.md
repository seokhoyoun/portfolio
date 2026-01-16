---
name: "[L사] BPA 가스검사기"
title: "[L사] BPA 가스검사기"
company: "피닉슨컨트롤스"
layout: page
tools: ["C#", "WPF", "Serial"]
description: 2차전지 양산 공정 내 가스 검사 공정 S/W 개발.
---

![BPA 가스검사기 UI](/assets/images/projects/lg-energy-bpa-gas-tester.png)

## Overview
- 기간: 2019.07 ~ 2020.09
- 소속: 피닉슨컨트롤스
- 역할: 개발
- 주요 업무: 장비 연동 및 검사 UI 구현

## Background
2차전지 양산 공정에서 BPA 공정 가스 품질을 검사하는 장비의 운영 소프트웨어를 개발했습니다.
36채널 센서 데이터를 수집해 1차/2차 검사 결과를 판단하고, PLC/Relay 제어 및 로깅을 통해
현장 운용성과 추적성을 확보하는 데 중점을 두었습니다.

## Key Features
- 1차/2차 검사 로직 구현 (1차는 최종 값, 2차는 전 채널 비교)
- 36채널 센서 통신 상태 모니터링 및 결과 UI 표시
- PLC 비트 상태 표시/로깅, Auto/Manual 상태에 따른 기능 제어
- Relay 제어 기반 센서 초기화(Reset) 및 검사 종료 시 타워램프 리셋
- 로그 체계 구축: AllDay, RawData, GasRawData, Result
- 바코드 기반 결과 관리 및 일자/월 단위 저장 구조
- 설정 화면(MES/PLC 프로퍼티) 및 작업자 접근 제한(PASSWORD) 추가

## What I Built
- WPF 기반 메인 검사 화면/설정 화면 구현 및 UX 개선
- Serial 기반 센서 통신/데이터 로깅 파이프라인 구현
- 현장 이슈 대응(로그 가독성 개선, UI 표시 방식 변경, 예외 처리 보강)

## Stack
- C#, WPF, Serial
