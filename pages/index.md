---
layout: default
permalink: /
---

<style>
  .home-wrap {
    max-width: 960px;
    margin: 48px auto;
    padding: 0 16px;
  }
  .home-hero {
    display: grid;
    grid-template-columns: 120px 1fr;
    gap: 20px;
    align-items: center;
  }
  .home-hero img {
    width: 120px;
    height: 120px;
    border-radius: 12px;
    object-fit: cover;
  }
  .home-hero h1 {
    margin: 0 0 8px;
    font-size: 28px;
  }
  .home-hero p {
    margin: 0 0 12px;
  }
  .home-section {
    margin-top: 32px;
  }
  .home-section h2 {
    margin: 0 0 12px;
    font-size: 18px;
  }
  .home-list {
    margin: 0;
    padding-left: 18px;
  }
  .home-grid {
    display: grid;
    gap: 12px;
  }
  .home-card {
    padding: 12px 14px;
    border: 1px solid #e5e7eb;
    border-radius: 10px;
  }
  .home-card h3 {
    margin: 0 0 6px;
    font-size: 16px;
  }
  .home-meta {
    font-size: 13px;
    color: #6b7280;
  }
  @media (max-width: 640px) {
    .home-hero {
      grid-template-columns: 1fr;
      text-align: left;
    }
    .home-hero img {
      width: 96px;
      height: 96px;
    }
  }
</style>

<div class="home-wrap">
  <section class="home-hero">
    <img src="{{ site.baseurl }}/assets/images/윤석호0501web.jpg" alt="{{ site.author.name }}">
    <div>
      <h1>{{ site.author.name }}</h1>
      <p>현장 중심 SI 개발 경험을 바탕으로 물류/제조 시스템을 구축하는 C# 개발자입니다.</p>
      <div class="home-meta">
        <span>Base: Korea</span> ·
        <a href="https://github.com/{{ site.author.github }}">GitHub</a>
      </div>
    </div>
  </section>

  <section class="home-section">
    <h2>Highlights</h2>
    <ul class="home-list">
      <li>WPF/WinForms 기반 장비 연동 및 공정 시스템 개발</li>
      <li>MES 연동 및 물류 자동화 프로젝트 경험</li>
      <li>검사/분석 S/W와 데이터 파이프라인 구축</li>
    </ul>
  </section>

  <section class="home-section">
    <h2>Projects</h2>
    {% assign items = site.projects | sort: "date" | reverse | slice: 0, 4 %}
    <div class="home-grid">
      {% for project in items %}
        <div class="home-card">
          <h3><a href="{{ project.url | relative_url }}">{{ project.name }}</a></h3>
          {% if project.description %}
            <div class="home-meta">{{ project.description }}</div>
          {% endif %}
        </div>
      {% endfor %}
    </div>
    <div class="home-meta" style="margin-top: 8px;">
      <a href="{{ '/projects/' | relative_url }}">프로젝트 전체 보기</a>
    </div>
  </section>

  <section class="home-section">
    <h2>Core Skills</h2>
    <ul class="home-list">
      {% for skill in site.data.programming-skills %}
        <li>{{ skill.name }}</li>
      {% endfor %}
    </ul>
  </section>
</div>
