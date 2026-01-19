---
layout: page
title: Side Projects
permalink: /side-projects/
weight: 2
---

# Side Projects

<style>
  .project-list {
    max-width: 960px;
    margin: 48px auto;
    padding: 0 16px;
  }
  .project-item {
    padding: 16px 0;
    border-bottom: 1px solid #e5e7eb;
  }
  .project-title {
    margin: 0;
    font-size: 18px;
    font-weight: 600;
  }
  .project-date {
    margin-left: 8px;
    font-size: 12px;
    font-weight: 500;
    color: #6b7280;
    white-space: nowrap;
  }
  .project-title a {
    color: inherit;
    text-decoration: none;
  }
  .project-desc {
    margin: 6px 0 0;
  }
  .project-meta {
    margin-top: 6px;
    font-size: 13px;
    color: #6b7280;
  }
  .project-meta a {
    color: inherit;
  }
</style>

<div class="project-list">
  {% assign items = site.side_projects | sort: "period_start" | reverse %}
  {% for project in items %}
    <div class="project-item">
      <h2 class="project-title">
        <a href="{{ project.url | relative_url }}">{{ project.title }}</a>
        {% if project.period_start %}
          <span class="project-date">
            {{ project.period_start }}{% if project.period_end %} ~ {{ project.period_end }}{% else %} ~ 현재{% endif %}
          </span>
        {% endif %}
      </h2>
      {% if project.description %}
        <p class="project-desc">{{ project.description }}</p>
      {% endif %}
      {% if project.tools %}
        <div class="project-meta">Tech: {{ project.tools | join: ", " }}</div>
      {% endif %}
      {% if project.repo %}
        <div class="project-meta">Repo: <a href="{{ project.repo }}">{{ project.repo }}</a></div>
      {% endif %}
    </div>
  {% endfor %}
</div>
